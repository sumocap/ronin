/**************************************************************************
 * Copyright (c) 2008 by Ronin Capital, LLC
 *
 * All Rights Reserved
 *************************************************************************/
#ifndef _DART_ROM_TO_BOE_H__
#define _DART_ROM_TO_BOE_H__

#include <pthread.h>

#include "databuf.h"
#include "connection_interface.h"
#include "risk_cntr_structs.h"
#include "order_token_generator.h"


#pragma pack(push, 1)
/*DART to BOE*/
typedef struct boe_new_ord {
    unsigned short som;
    unsigned short len;
    unsigned char type;
    unsigned char mu;
    unsigned int seq;
    char ord_id[20];
    unsigned char side;
    unsigned int qty;
    unsigned char nnobfields;
    unsigned char bf1;
    unsigned char bf2;
    unsigned char bf3;
    unsigned char bf4;
    unsigned char bf5;
    unsigned char bf6;
    unsigned char bf7;
    unsigned char bf8;
    unsigned char bf9;
}boeno;

typedef struct boe_cnl_ord {
    unsigned short som;
    unsigned short len;
    unsigned char type;
    unsigned char mu;
    unsigned int seq;
    char orig_id[20];
    unsigned char ncnlbfields;
    uint8_t bf1;
    uint8_t bf2;
}boecnl;

typedef struct boe_rpl_ord {
    unsigned short som;
    unsigned short len;
    unsigned char type;
    unsigned char mu;
    unsigned int seq;
    char ord_id[20];
    char orig_id[20];
    unsigned char nrplbfields;
    unsigned char bf1;
    unsigned char bf2;
}boerpl;
/* BOE TO DART */
typedef struct boe_open {
    unsigned short som;
    unsigned short len;
    unsigned char type;
    unsigned char mu;
    unsigned int seq;
    unsigned long tt;
    char ord_id[20];
    unsigned long bats_id;
} boeack;

typedef struct boe_rej {
    unsigned short som;
    unsigned short len;
    unsigned char type;
    unsigned char mu;
    unsigned int seq;
    unsigned long tt;
    char ord_id[20];
    unsigned char rr;
    char text[60];
} boerej;

typedef struct boe_restate {
    unsigned short som;
    unsigned short len;
    unsigned char type;
    unsigned char mu;
    unsigned int seq;
    unsigned long tt;
    char ord_id[20];
    unsigned long bats_id;
    unsigned char rr;
} boere;

typedef struct boe_out {
    unsigned short som;
    unsigned short len;
    unsigned char type;
    unsigned char mu;
    unsigned int seq;
    unsigned long tt;
    char ord_id[20];
    unsigned char cr;
} boeout;

typedef struct boe_mod {
    unsigned short som;
    unsigned short len;
    unsigned char type;
    unsigned char mu;
    unsigned int seq;
    unsigned long tt;
    char ord_id[20];
    unsigned long bats_id;
} boemod;

typedef struct boe_cnl_rej {
    unsigned short som;
    unsigned short len;
    unsigned char type;
    unsigned char mu;
    unsigned int seq;
    unsigned long tt;
    char ord_id[20];
    unsigned char rr;
    char text[60];
} boecnlrej;

typedef struct boe_mod_rej {
    unsigned short som;
    unsigned short len;
    unsigned char type;
    unsigned char mu;
    unsigned int seq;
    unsigned long tt;
    char ord_id[20];
    unsigned char rr;
    char text[60];
} boemodrej;

typedef struct boe_fill {
    unsigned short som;
    unsigned short len;
    unsigned char type;
    unsigned char mu;
    unsigned int seq;
    unsigned long tt;
    char ord_id[20];
    unsigned long execid;
    unsigned int lshares;
    unsigned long lprice;
    unsigned int leaves;
    unsigned char liq;
    unsigned char subliq;
    char contra[4];
} boefill;

typedef struct boe_tas_restate {
    unsigned short som;
    unsigned short len;
    unsigned char type;
    unsigned char mu;
    unsigned int seq;
    unsigned long tt;
    char ord_id[20];
    unsigned long execid;
} boetasre;

typedef struct boe_bust_or_correct {
    unsigned short som;
    unsigned short len;
    unsigned char type;
    unsigned char mu;
    unsigned int seq;
    unsigned long tt;
    char ord_id[20];
    unsigned long bats_id;
    unsigned long execid;
    unsigned char side;
    unsigned char liq;
    unsigned char clear_firm[4];
    unsigned char clear_acct[4];
    unsigned int lshares;
    unsigned long lprice;
    unsigned long real_price;
    unsigned long orig_time;
} boebust;
typedef struct boe_cmplx_accept {
    unsigned short som;
    unsigned short len;
    unsigned char type;
    unsigned char mu;
    unsigned int seq;
    unsigned long tt;
    char ord_id[20];
    char symbol[8];
    char revised_legs;
    uint32_t num_sec;
}boecmplxacc;
/*Type 0x4B*/
typedef struct boe_cmplx_order {
    unsigned short som;
    unsigned short len;
    unsigned char type;
    unsigned char mu;
    unsigned int seq;
    char ord_id[20];
    uint8_t side;
    uint32_t qty;
    uint8_t num_bits;
    uint8_t bf1;
    uint8_t bf2;
    uint8_t bf3;
    uint8_t bf4;
    uint8_t bf5;
    uint8_t bf6;
    uint8_t num_legs;
}boecmplxord;
/*Type 0x4C*/
typedef struct boe_new_cmplx_request {
    unsigned short som;
    unsigned short len;
    unsigned char type;
    unsigned char mu;
    unsigned int seq;
    char ord_id[20];
    uint8_t num_bits;
    uint8_t bit_one;
    uint8_t num_legs;
} boecmplxreq;

typedef struct boe_leg_pack {
  char legSymbol[8];
  char legCfi[6];
  uint32_t legMatDate;
  uint64_t legStrike;
  uint32_t legRatio;
  uint8_t legSide;
}boeleg;
#pragma pack(pop)



int create_boe_new_order_message(databuf_t * buff, rcntr *rph,
                             con_int* ob, token_gen* tg, uint64_t seq);
int create_boe_cancel_message(databuf_t * buff, rcntr *rph,
                          con_int* ob, uint64_t seq);
int create_boe_replace_message(databuf_t * buff, rcntr *rph,
                           con_int* ob, token_gen* tg, uint64_t seq);
long rom_to_boe_price(char *price, size_t len);
int create_boe_cmplx_instrument(databuf_t* buff, rcntr* v,
    con_int* ob, token_gen* tg, uint64_t seq);
int create_ex_boe_cmplx_ord(databuf_t* buff, rcntr* v, 
        con_int* ob, token_gen* tg, uint64_t seq);
int create_boe_cmplx_order(databuf_t* buff, rcntr* v,
    con_int* ob, token_gen* tg, uint64_t seq, char* ack);

double boe_to_rom_price(int data, char ps);
int trans_mat_ymd(char* year_mon, int ymlen, char* day, int dlen);
int boe_translate_rom_symbol(char *output, char *symbol, size_t sym_len);
void init_today();
void set_date_str(char *output, long tt);
int boe_parse_order_ack(rcntr * ute, char *ack, con_int* ob);
int boe_parse_order_restated(rcntr* cnt, char* ack, con_int* ob);
int boe_parse_ur_out(rcntr * ute, char *ack, con_int* ob);
int boe_parse_cancel_rej(rcntr * ute, char *ack, con_int* ob);
int boe_parse_rep_rej(rcntr * ute, char *ack, con_int* ob);
int boe_parse_replaced(rcntr * ute, char *ack, con_int* ob);
int boe_parse_rej(rcntr * ute, char *ack, con_int* ob);
int boe_parse_filled(rcntr * ute, char *ack, con_int* ob);
void boe_parse_tas_restate(rcntr * ute, char* ack, con_int* ob);
int find_cfe_base_spread_sym(const char* symbol, int len);
int find_cfe_base_sym(const char* symbol, int len);
#endif

