/**************************************************************************
 * Copyright (c) 2014 by DART Executions LLC
 *
 * All Rights Reserved
 *************************************************************************/
#include <string.h>
#include <math.h>

#include "dart_constants.h"
#include "async_server.h"
#include "parser_func.h"
#include "ice_sym_trans.h"
#include "hashmap.h"
#include "service_bureau.h"


#define NEXT_SPACE(off, end)                                   \
    do {                                                     \
        ++off;                                               \
        --end;                                               \
    } while(*off != 0x20 && end > 0);             \
/*static char* month_codes[] = { "Y", "F", "G", "H", "J", "K", 
                           "M", "N", "Q", "U", "V", "X",
                           "Z", "F"}; 
*/
static int nybot_table[] =  {0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             1,1,1,1,1,0,1,0,1,0,
                             0,0,0,0,0,0,0,0,0,1,
                             0,1,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0};

static int ronin_sym_len[] =  {0,0,0,0,0,2,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             2,2,2,0,2,0,0,2,3,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0};
static char* ronin_sym[] =  {0,0,0,0,0,"CO",0,0,0,0,
                             0,0,0,0,0,0,0,0,0,"CA",
                             "CC","KC","CT",0,"SB",0,0,"HO","RTA",0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0,
                             0,0,0,0,0,0,0,0,0,0};
struct ice_sym_trans {
    hashmap_t ice_to_dart;
    hashmap_t dart_to_ice;
    hashmap_t is_nybot;
    hashmap_t ice_to_sec_def;
    sbureau_match* sbm;
};

ice_sym_t* init_sym_trans(char* filename)
{
    ice_sym_t* ist = malloc(sizeof(struct ice_sym_trans));
    ist->ice_to_dart = create_map(32768);
    ist->dart_to_ice = create_map(32768);
    ist->ice_to_sec_def = create_map(32768);
    ist->is_nybot = create_map(16384);
    ist->sbm = create_service_bureau_matcher(filename);
    return ist;
}
void set_mifid_fields(ice_sym_t* ist, dart_order_obj* obj, ofp* fix_obj, 
       trans_t* t)
{
    int mpid_len = 0;
    char* mifid_id = get_mpid_for_clr_acct(ist->sbm,
            obj->positions[ROM_TRADE_FOR].iov_base,
            obj->positions[ROM_TRADE_FOR].iov_len,
            &mpid_len);
    if(mpid_len > 0) {
        set_fix_val(t, fix_obj, 9707,mifid_id, mpid_len);
    }
}

int get_is_nybot(ice_sym_t* ist, char* sym, int sym_len)
{
     return contains_key(ist->is_nybot,sym, sym_len);
}

char* get_ice_sym(ice_sym_t* ist, char* rsym, int rsym_len, 
        int* ice_len)
{
    char* ret_sym = 0;
    int sym_len = find_n_fill(ist->dart_to_ice, rsym, rsym_len, (void**)&ret_sym);
    *ice_len = sym_len;
    return ret_sym;
}
char* get_dart_sym(ice_sym_t* ist, char* rsym, int rsym_len,
                    int * ice_len)
{
    char* ret_sym = 0;
    int sym_len = find_n_fill(ist->ice_to_dart, rsym, rsym_len, (void**)&ret_sym);
    *ice_len = sym_len;
    return ret_sym;
}

ice_sec_def* get_sec_def(ice_sym_t* ist, char* sym, int sym_len)
{
    ice_sec_def* ret = 0;
     int len = get_map_entry(ist->ice_to_sec_def, sym,
                               sym_len, (void *)&ret);
     if(len > 0) {
         return ret;
     } else {
         return NULL;
     } 
}


void print_symbol_lists(ice_sym_t* gk, databuf_t * buff)
{
    char *dest_route = 0;
    char *key = 0;
    int key_len = 0;
    hashmap_iterator_t hi = hashmap_iterator_begin(gk->dart_to_ice);
    int valid =
        hashmap_iterator_dereference(hi, &key, &key_len,
                (void *) &dest_route);
    while (valid) {
        databuf_write(buff, "%s=%s;\n", key, dest_route);
        valid = hashmap_iterator_next(gk->dart_to_ice, hi);
        if (!valid) {
            break;
        }
        valid =
            hashmap_iterator_dereference(hi, &key,
                    &key_len, (void *) &dest_route);
    }
    hashmap_iterator_destroy(hi);
}

static void build_ice_sec_id(ice_sym_t* ist, dart_order_obj* obj, 
        char* offset, int off_len, int len_left, char* val_end, 
        int sec_req_id)
{
    char* end = val_end;
    char* parent_sym = 0;
    int found = find_n_fill(ist->ice_to_dart,
            getpval(obj, 6), getplen(obj, 6),
            (void**)&parent_sym);
    int found_end = 0;
    GET_OFF(end, len_left, "311", 3, found_end); 
    if(len_left > 0 && found && found_end) {
        ice_sec_def* isd = calloc(1, sizeof(struct ice_sec_def));
        int t_len = end - offset;
        char* finder = val_end;
        char final_sym[128];
        memset(final_sym, '\0', 128);
        memcpy(final_sym, parent_sym, found -1);
        isd->sec_type = 'O';
        char* d_off = final_sym;
        d_off += found -1;
        memcpy(d_off, "_OM", 3);
        d_off += 3;
        int s_len = t_len;
        GET_OFF(finder, s_len, "315=", 4,found);
        if(found) {
           finder = finder + 4;
           if(finder[0] == '0')  {
               *d_off++ = 'P';
               isd->p_or_c = 'P';
           } else {
               *d_off++ = 'C';
               isd->p_or_c = 'C';
           }
           *d_off++ = 'A'; 
        } else {
            goto error;
        }
        s_len = t_len;
        finder = val_end;
        {
            GET_OFF(finder, s_len, "316=", 4, found);
        }
        if(found) {
            finder += 4;
            double strike = atof(finder);
            {
                GET_OFF(finder, s_len, "9085=", 5, found); 
            }
            if(found) {
                finder += 5;
                int num_dec = atoi(finder);
                strike += 0.00001;
                strike = strike * ((double)pow(10.0, num_dec));
                num_dec = sprintf(d_off, "%09d", (int)strike);
                d_off += num_dec;
                *d_off++ = finder[0];
                finder = val_end;
                s_len = t_len;
                {
                    GET_OFF(finder, s_len, "313=", 4, found);
                }
                /**
                 * Need to zero pad the maturity day
                 */
                if(found) {
                    memcpy(isd->mat_mon_year, finder + 4, 6);
                    isd->mmy_len = 6;
                    char* month = finder + 8;
                    finder += 15;
                    val_end = finder;
                    NEXT_ONE(val_end, s_len);
                    memcpy(d_off, month, 2);
                    d_off += 2;
                    if((val_end - finder) == 2) {
                        memcpy(d_off, finder, 2);
                        d_off += 2;
                        memcpy(isd->mat_day, finder, 2);
                        isd->m_day_len = 2;
                    } else {
                        *d_off++ = '0';
                        memcpy(d_off, finder, 1);
                        ++d_off;
                        memcpy(isd->mat_day, finder, 1);
                        isd->m_day_len = 1;
                    }
                    memcpy(d_off, month -2, 2);
                    d_off += 2;
                    insert_map(ist->ice_to_dart, offset, off_len,
                            final_sym, (d_off - final_sym));
                    insert_map(ist->dart_to_ice, final_sym, (d_off - final_sym), 
                            offset, off_len);
                    if(sec_req_id < 160 && nybot_table[sec_req_id]) {
                        insert_map(ist->is_nybot,final_sym, (d_off - final_sym), 
                            offset, off_len);
                    }
                    if(sec_req_id < 160 && ronin_sym[sec_req_id] != 0x0 &&
                            ronin_sym_len[sec_req_id] > 0) {
                        memcpy(isd->ronin_sym,ronin_sym[sec_req_id], ronin_sym_len[sec_req_id]);
                        isd->r_sym_len = ronin_sym_len[sec_req_id];
                    } else {
                        isd->r_sym_len = 0;
                    }
                    no_copy_insert(ist->ice_to_sec_def, offset, off_len,
                            isd); 
                } else {
                    goto error;
                }
            } else {
                goto error;
            }
        } else {
            goto error;
        }
        return;
error:
            printf("Failed on: %s \n", final_sym);
    } else {
        char output[16];
        memset(output, '\0', 16);
        int cp_len = off_len < 16 ? off_len : 15;
        memcpy(output, offset, cp_len);
        printf("Could not find: %s \n", output); 

    }
}

void ice_handle_uds(ice_sym_t* ist, dart_order_obj* doj, void* apa)
{
    if(doj->positions[FIX_SYM].iov_len > 0 && 
            doj->positions[FIX_SEC_DEF].iov_len > 0) {
            insert_map(ist->ice_to_dart,doj->positions[FIX_SYM].iov_base,
                    doj->positions[FIX_SYM].iov_len, doj->positions[FIX_SEC_DEF].iov_base,
                    doj->positions[FIX_SEC_DEF].iov_len);
            insert_map(ist->dart_to_ice, doj->positions[FIX_SEC_DEF].iov_base,
                    doj->positions[FIX_SEC_DEF].iov_len, doj->positions[FIX_SYM].iov_base,
                    doj->positions[FIX_SYM].iov_len);
    }
}

void build_mapping(ice_sym_t* ist, dart_order_obj* obj, void* v)
{
    struct async_parse_args *apa = (struct async_parse_args *) v;
    sock_recv_manager* rph = apa->con;
    long len = obj->current->data->buflen;
    char* tag = rph->rd_ptr; 
    char* val = tag;
    char* end = tag;
    if(getplen(obj, 20) > 0) {
        int no_syms = atoi(getpval(obj, 20));
        int seq_req_id = atoi(getpval(obj, 3));
        do {
            if(*end == '=') {
                val = end;
                NEXT_ONE(end, len);
                if(3 == (val - tag) && strncmp("311", tag, 3) == 0) {
                    ++val;
                    --no_syms;
                    char* sec_id = end + 1;
                    if(strncmp(sec_id, "309", 3) == 0) {
                        sec_id += 4;
                        char* un_sec_id = sec_id;
                        long len_left = len;
                        NEXT_ONE(un_sec_id, len_left);
                        insert_map(ist->ice_to_dart, val, end - val,
                                sec_id, un_sec_id - sec_id);
                        insert_map(ist->dart_to_ice, sec_id, un_sec_id - sec_id, 
                                val, end - val);
                        if(seq_req_id < 160 && nybot_table[seq_req_id]) {
                            insert_map(ist->is_nybot, sec_id, un_sec_id - sec_id, 
                                    val, end - val);
                        }
                        ice_sec_def* isd = calloc(1, sizeof(struct ice_sec_def));
                        int found = 0;
                        long sec_len = len_left;
                        char* sec_type = un_sec_id;
                        {
                            GET_OFF(sec_type, sec_len, "463=", 4, found);
                            if(found) {
                                sec_type += 4;
                                switch (sec_type[0]) {
                                    default:
                                        isd->sec_type = 'F';
                                        break;
                                    case 'O':
                                        isd->sec_type = 'O';
                                        break;
                                }
                            } else {
                                isd->sec_type = 'F';
                            }
                        }
                        found = 0;
                        long p_c_len = len_left;
                        char* pc = un_sec_id;
                        {
                            GET_OFF(pc, p_c_len, "315=", 4, found);
                            if(found) {
                                pc += 4;
                                switch (pc[0]) {
                                    default:
                                        isd->p_or_c = 'C';
                                        break;
                                    case '0':
                                        isd->p_or_c = 'P';
                                        break;
                                }
                            } else {
                                isd->p_or_c = ' ';
                            }
                        }
                        found = 0;
                        char* strike = un_sec_id;
                        long strike_len = len_left;
                        {
                            GET_OFF(strike, strike_len, "316=", 4, found);
                            if(found) {
                                strike += 4;
                                char* send = strike;
                                NEXT_ONE(send, strike_len);
                                if(send != 0x0 && send - strike > 0) { 
                                    memset(isd->strike, '\0',16);
                                    int cp_len = (send - strike) <= 15 ? (send - strike) : 15;
                                    memcpy(isd->strike, strike, cp_len);
                                    isd->strike_len = cp_len;
                                }
                            }
                        }
                        found = 0; 
                        char* mat_off = un_sec_id;
                        {
                            GET_OFF(mat_off, len_left, "542=", 4, found);
                            if(found) {
                                mat_off += 4;
                                memcpy(isd->mat_mon_year, mat_off, 8);
                                isd->mmy_len = 6;
                                //int imonth = atoi(mat_off + 4);
                                mat_off += 6;
                                char* beg = mat_off;
                                memcpy(isd->mat_day, beg, 2);
                                isd->m_day_len = 2;
                                if(seq_req_id < 160 && ronin_sym[seq_req_id] != 0x0 &&
                                        ronin_sym_len[seq_req_id] > 0) {
                                    memcpy(isd->ronin_sym,ronin_sym[seq_req_id], ronin_sym_len[seq_req_id]);
                                    memcpy(isd->ronin_sym + ronin_sym_len[seq_req_id], sec_id + 6, 1);//month_codes[imonth], 1);
                                    memcpy(isd->ronin_sym + ronin_sym_len[seq_req_id] + 1, sec_id + 10, 1);//isd->mat_mon_year +3, 1);
                                    isd->r_sym_len = ronin_sym_len[seq_req_id] + 2;
                                } else {
                                    char* off = sec_id;
                                    int off_len = 4;//ICE symbol code is never more than 4 chars.
                                    NEXT_SPACE(off, off_len);
                                    off_len = 4 - off_len;
                                    if(off_len == 1 && sec_id[0] == 'C') {
                                        memcpy(isd->ronin_sym,"CQ", 2);
                                        off_len = 2;
                                    } else {
                                        memcpy(isd->ronin_sym,sec_id,off_len);
                                    }
                                    memcpy(isd->ronin_sym + off_len, sec_id + 6, 1);
                                    memcpy(isd->ronin_sym + off_len + 1, sec_id + 10, 1);
                                    isd->r_sym_len = off_len + 2;
                                }
                            }
                        }
                        no_copy_insert(ist->ice_to_sec_def, val, end - val,
                                isd);

                    } else if(getplen(obj,6) > 0) {
                        build_ice_sec_id(ist, obj, val, end - val, len, end, seq_req_id);
                    }
                }
                tag = end + 1;
            }
            ++end;
            --len;
        } while(len > 0 && no_syms > 0);
    } 
}
