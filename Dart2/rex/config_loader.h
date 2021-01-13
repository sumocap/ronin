/**************************************************************************
 * Copyright (c) 2008 by Ronin Capital, LLC
 *
 * All Rights Reserved
 *************************************************************************/
#ifndef _CONFIG_LOADER_H__
#define _CONFIG_LOADER_H__
#if defined(__cplusplus)
extern "C" {
#endif
#include "hashmap.h"

typedef struct config_loader rex_config;

rex_config *initialize_config(const char *filename, int len);
void rex_destroy_config(rex_config* df);
char *get_val_for_tag(rex_config * df, const char *section,
                      int sec_len, const char *tag,
                      int tag_len, int *val_len);
void set_val_for_tag(rex_config * df, const char *section,
                     int sec_len, const char *tag,
                     int tag_len, char *val, int val_len);
void rex_reset_maps(rex_config * df);
char *get_file_contents(const char *filename, long *size);
int build_map_from_file(const char *filename, hashmap_t map);
int lock_config_loader(rex_config* doj);
int unlock_config_loader(rex_config * doj);
char* get_no_copy_val(rex_config* df, const char* section, int sec_len,
                      const char* tag, int tag_len, int* val_len);
int cp_to_buff(rex_config* ex, const char* header, int hlen,
                     const char* tag, int tlen, char* output,
                     int max_len);

#if defined(__cplusplus)
}
#endif
#endif