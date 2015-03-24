//
//  main.c
//  CDirectories
//
//  Created by Michael Köppl on 24/03/15.
//  Copyright (c) 2015 Michael Köppl. All rights reserved.
//

#include <stdio.h>
#include <sys/types.h>
#include <dirent.h>

int main(int argc, const char * argv[]) {
    DIR *dp;
    struct dirent *ep;
    dp = opendir ("/Users/Shared");
    
    if (dp != NULL)
    {
        while ((ep = readdir (dp))){
            puts (ep->d_name);
        }
        
        (void) closedir (dp);
    }else {
        printf("Couldn't open the directory");
    }
    return 0;
}
