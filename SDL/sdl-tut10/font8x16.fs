\ ===[ Code Addendum 07 ]============================================
\                 gforth: SDL/OpenGL Graphics Part X
\ ===================================================================
\    File Name: font8x16.fs
\       Author: Timothy Trussell
\         Date: 03/28/2010
\  Description: 8x16 font in a packed-pixel format
\ Forth System: gforth-0.7.0
\ Linux System: Ubuntu v9.10 i386, kernel 2.6.31-20
\ C++ Compiler: gcc (Ubuntu 4.4.1-4ubuntu9) 4.4.1
\ ===================================================================
\                  This font is in the Public Domain
\ ===================================================================

create Font8x16[]
hex
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 07E C, 081 C, 0A5 C, 081 C, 081 C, 0BD C, 
099 C, 081 C, 081 C, 07E C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 07E C, 0FF C, 0DB C, 0FF C, 0FF C, 0C3 C, 
0E7 C, 0FF C, 0FF C, 07E C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 06C C, 0FE C, 0FE C, 0FE C, 
0FE C, 07C C, 038 C, 010 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 010 C, 038 C, 07C C, 0FE C, 
07C C, 038 C, 010 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 018 C, 03C C, 03C C, 0E7 C, 0E7 C, 
0E7 C, 099 C, 018 C, 03C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 018 C, 03C C, 07E C, 0FF C, 0FF C, 
07E C, 018 C, 018 C, 03C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 018 C, 03C C, 
03C C, 018 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 0E7 C, 0C3 C, 
0C3 C, 0E7 C, 0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 
000 C, 000 C, 000 C, 000 C, 000 C, 03C C, 066 C, 042 C, 
042 C, 066 C, 03C C, 000 C, 000 C, 000 C, 000 C, 000 C, 
0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 0C3 C, 099 C, 0BD C, 
0BD C, 099 C, 0C3 C, 0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 
000 C, 000 C, 01E C, 00E C, 01A C, 032 C, 078 C, 0CC C, 
0CC C, 0CC C, 0CC C, 078 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 03C C, 066 C, 066 C, 066 C, 066 C, 03C C, 
018 C, 07E C, 018 C, 018 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 03F C, 033 C, 03F C, 030 C, 030 C, 030 C, 
030 C, 070 C, 0F0 C, 0E0 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 07F C, 063 C, 07F C, 063 C, 063 C, 063 C, 
063 C, 067 C, 0E7 C, 0E6 C, 0C0 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 018 C, 018 C, 0DB C, 03C C, 0E7 C, 
03C C, 0DB C, 018 C, 018 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 080 C, 0C0 C, 0E0 C, 0F0 C, 0F8 C, 0FE C, 0F8 C, 
0F0 C, 0E0 C, 0C0 C, 080 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 002 C, 006 C, 00E C, 01E C, 03E C, 0FE C, 03E C, 
01E C, 00E C, 006 C, 002 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 018 C, 03C C, 07E C, 018 C, 018 C, 018 C, 
018 C, 07E C, 03C C, 018 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 066 C, 066 C, 066 C, 066 C, 066 C, 066 C, 
066 C, 000 C, 066 C, 066 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 07F C, 0DB C, 0DB C, 0DB C, 07B C, 01B C, 
01B C, 01B C, 01B C, 01B C, 000 C, 000 C, 000 C, 000 C, 
000 C, 07C C, 0C6 C, 060 C, 038 C, 06C C, 0C6 C, 0C6 C, 
06C C, 038 C, 00C C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
0FE C, 0FE C, 0FE C, 0FE C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 018 C, 03C C, 07E C, 018 C, 018 C, 018 C, 
018 C, 07E C, 03C C, 018 C, 07E C, 000 C, 000 C, 000 C, 
000 C, 000 C, 018 C, 03C C, 07E C, 018 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 018 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
018 C, 07E C, 03C C, 018 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 018 C, 00C C, 0FE C, 
00C C, 018 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 030 C, 060 C, 0FE C, 
060 C, 030 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0C0 C, 0C0 C, 0C0 C, 
0C0 C, 0FE C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 028 C, 06C C, 0FE C, 
06C C, 028 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 010 C, 038 C, 038 C, 07C C, 
07C C, 0FE C, 0FE C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 0FE C, 0FE C, 07C C, 07C C, 
038 C, 038 C, 010 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 018 C, 03C C, 03C C, 03C C, 018 C, 018 C, 
018 C, 000 C, 018 C, 018 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 066 C, 066 C, 066 C, 024 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 06C C, 06C C, 0FE C, 06C C, 06C C, 
06C C, 0FE C, 06C C, 06C C, 000 C, 000 C, 000 C, 000 C, 
018 C, 018 C, 07C C, 0C6 C, 0C2 C, 0C0 C, 07C C, 006 C, 
086 C, 0C6 C, 07C C, 018 C, 018 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 0C2 C, 0C6 C, 00C C, 018 C, 
030 C, 060 C, 0C6 C, 086 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 038 C, 06C C, 06C C, 038 C, 076 C, 0DC C, 
0CC C, 0CC C, 0CC C, 076 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 030 C, 030 C, 030 C, 060 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 00C C, 018 C, 030 C, 030 C, 030 C, 030 C, 
030 C, 030 C, 018 C, 00C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 030 C, 018 C, 00C C, 00C C, 00C C, 00C C, 
00C C, 00C C, 018 C, 030 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 066 C, 03C C, 0FF C, 
03C C, 066 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 018 C, 018 C, 07E C, 
018 C, 018 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 018 C, 018 C, 018 C, 030 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 0FE C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 018 C, 018 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 002 C, 006 C, 00C C, 018 C, 
030 C, 060 C, 0C0 C, 080 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 07C C, 0C6 C, 0C6 C, 0CE C, 0D6 C, 0D6 C, 
0E6 C, 0C6 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 018 C, 038 C, 078 C, 018 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 07E C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 07C C, 0C6 C, 006 C, 00C C, 018 C, 030 C, 
060 C, 0C0 C, 0C6 C, 0FE C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 07C C, 0C6 C, 006 C, 006 C, 03C C, 006 C, 
006 C, 006 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 00C C, 01C C, 03C C, 06C C, 0CC C, 0FE C, 
00C C, 00C C, 00C C, 01E C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0FE C, 0C0 C, 0C0 C, 0C0 C, 0FC C, 00E C, 
006 C, 006 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 038 C, 060 C, 0C0 C, 0C0 C, 0FC C, 0C6 C, 
0C6 C, 0C6 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0FE C, 0C6 C, 006 C, 006 C, 00C C, 018 C, 
030 C, 030 C, 030 C, 030 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 07C C, 0C6 C, 0C6 C, 0C6 C, 07C C, 0C6 C, 
0C6 C, 0C6 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 07C C, 0C6 C, 0C6 C, 0C6 C, 07E C, 006 C, 
006 C, 006 C, 00C C, 078 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 018 C, 018 C, 000 C, 000 C, 
000 C, 018 C, 018 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 018 C, 018 C, 000 C, 000 C, 
000 C, 018 C, 018 C, 030 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 006 C, 00C C, 018 C, 030 C, 060 C, 
030 C, 018 C, 00C C, 006 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 0FE C, 000 C, 
000 C, 0FE C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 060 C, 030 C, 018 C, 00C C, 006 C, 
00C C, 018 C, 030 C, 060 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 07C C, 0C6 C, 0C6 C, 00C C, 018 C, 018 C, 
018 C, 000 C, 018 C, 018 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 07C C, 0C6 C, 0C6 C, 0DE C, 0DE C, 
0DE C, 0DC C, 0C0 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 010 C, 038 C, 06C C, 0C6 C, 0C6 C, 0FE C, 
0C6 C, 0C6 C, 0C6 C, 0C6 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0FC C, 066 C, 066 C, 066 C, 07C C, 066 C, 
066 C, 066 C, 066 C, 0FC C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 03C C, 066 C, 0C2 C, 0C0 C, 0C0 C, 0C0 C, 
0C0 C, 0C2 C, 066 C, 03C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0F8 C, 06C C, 066 C, 066 C, 066 C, 066 C, 
066 C, 066 C, 06C C, 0F8 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0FE C, 066 C, 062 C, 068 C, 078 C, 068 C, 
060 C, 062 C, 066 C, 0FE C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0FE C, 066 C, 062 C, 068 C, 078 C, 068 C, 
060 C, 060 C, 060 C, 0F0 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 03C C, 066 C, 0C2 C, 0C0 C, 0C0 C, 0DE C, 
0C6 C, 0C6 C, 066 C, 03A C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0C6 C, 0C6 C, 0C6 C, 0C6 C, 0FE C, 0C6 C, 
0C6 C, 0C6 C, 0C6 C, 0C6 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 03C C, 018 C, 018 C, 018 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 03C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 01E C, 00C C, 00C C, 00C C, 00C C, 00C C, 
0CC C, 0CC C, 0CC C, 078 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0E6 C, 066 C, 06C C, 06C C, 078 C, 078 C, 
06C C, 066 C, 066 C, 0E6 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0F0 C, 060 C, 060 C, 060 C, 060 C, 060 C, 
060 C, 062 C, 066 C, 0FE C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0C6 C, 0EE C, 0FE C, 0FE C, 0D6 C, 0C6 C, 
0C6 C, 0C6 C, 0C6 C, 0C6 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0C6 C, 0E6 C, 0F6 C, 0FE C, 0DE C, 0CE C, 
0C6 C, 0C6 C, 0C6 C, 0C6 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 038 C, 06C C, 0C6 C, 0C6 C, 0C6 C, 0C6 C, 
0C6 C, 0C6 C, 06C C, 038 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0FC C, 066 C, 066 C, 066 C, 07C C, 060 C, 
060 C, 060 C, 060 C, 0F0 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 07C C, 0C6 C, 0C6 C, 0C6 C, 0C6 C, 0C6 C, 
0C6 C, 0D6 C, 0DE C, 07C C, 00C C, 00E C, 000 C, 000 C, 
000 C, 000 C, 0FC C, 066 C, 066 C, 066 C, 07C C, 06C C, 
066 C, 066 C, 066 C, 0E6 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 07C C, 0C6 C, 0C6 C, 060 C, 038 C, 00C C, 
006 C, 0C6 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 07E C, 07E C, 05A C, 018 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 03C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0C6 C, 0C6 C, 0C6 C, 0C6 C, 0C6 C, 0C6 C, 
0C6 C, 0C6 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0C6 C, 0C6 C, 0C6 C, 0C6 C, 0C6 C, 0C6 C, 
0C6 C, 06C C, 038 C, 010 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0C6 C, 0C6 C, 0C6 C, 0C6 C, 0C6 C, 0D6 C, 
0D6 C, 0FE C, 06C C, 06C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0C6 C, 0C6 C, 06C C, 06C C, 038 C, 038 C, 
06C C, 06C C, 0C6 C, 0C6 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 066 C, 066 C, 066 C, 066 C, 03C C, 018 C, 
018 C, 018 C, 018 C, 03C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0FE C, 0C6 C, 086 C, 00C C, 018 C, 030 C, 
060 C, 0C2 C, 0C6 C, 0FE C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 03C C, 030 C, 030 C, 030 C, 030 C, 030 C, 
030 C, 030 C, 030 C, 03C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 080 C, 0C0 C, 0E0 C, 070 C, 038 C, 
01C C, 00E C, 006 C, 002 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 03C C, 00C C, 00C C, 00C C, 00C C, 00C C, 
00C C, 00C C, 00C C, 03C C, 000 C, 000 C, 000 C, 000 C, 
010 C, 038 C, 06C C, 0C6 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0FF C, 000 C, 000 C, 
030 C, 030 C, 018 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 078 C, 00C C, 07C C, 
0CC C, 0CC C, 0CC C, 076 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0E0 C, 060 C, 060 C, 078 C, 06C C, 066 C, 
066 C, 066 C, 066 C, 0DC C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 07C C, 0C6 C, 0C0 C, 
0C0 C, 0C0 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 01C C, 00C C, 00C C, 03C C, 06C C, 0CC C, 
0CC C, 0CC C, 0CC C, 076 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 07C C, 0C6 C, 0FE C, 
0C0 C, 0C0 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 038 C, 06C C, 064 C, 060 C, 0F0 C, 060 C, 
060 C, 060 C, 060 C, 0F0 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 076 C, 0CC C, 0CC C, 
0CC C, 0CC C, 0CC C, 07C C, 00C C, 0CC C, 078 C, 000 C, 
000 C, 000 C, 0E0 C, 060 C, 060 C, 06C C, 076 C, 066 C, 
066 C, 066 C, 066 C, 0E6 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 018 C, 018 C, 000 C, 038 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 03C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 006 C, 006 C, 000 C, 00E C, 006 C, 006 C, 
006 C, 006 C, 006 C, 006 C, 066 C, 066 C, 03C C, 000 C, 
000 C, 000 C, 0E0 C, 060 C, 060 C, 066 C, 06C C, 078 C, 
078 C, 06C C, 066 C, 0E6 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 038 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 03C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0EC C, 0FE C, 0D6 C, 
0D6 C, 0D6 C, 0D6 C, 0D6 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0DC C, 066 C, 066 C, 
066 C, 066 C, 066 C, 066 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 07C C, 0C6 C, 0C6 C, 
0C6 C, 0C6 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0DC C, 066 C, 066 C, 
066 C, 066 C, 066 C, 07C C, 060 C, 060 C, 0F0 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 076 C, 0CC C, 0CC C, 
0CC C, 0CC C, 0CC C, 07C C, 00C C, 00C C, 01E C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0DC C, 076 C, 062 C, 
060 C, 060 C, 060 C, 0F0 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 07C C, 0C6 C, 060 C, 
038 C, 00C C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 010 C, 030 C, 030 C, 0FC C, 030 C, 030 C, 
030 C, 030 C, 036 C, 01C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0CC C, 0CC C, 0CC C, 
0CC C, 0CC C, 0CC C, 076 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 066 C, 066 C, 066 C, 
066 C, 066 C, 03C C, 018 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0C6 C, 0C6 C, 0C6 C, 
0D6 C, 0D6 C, 0FE C, 06C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0C6 C, 06C C, 038 C, 
038 C, 038 C, 06C C, 0C6 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0C6 C, 0C6 C, 0C6 C, 
0C6 C, 0C6 C, 0C6 C, 07E C, 006 C, 00C C, 0F8 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0FE C, 0CC C, 018 C, 
030 C, 060 C, 0C6 C, 0FE C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 00E C, 018 C, 018 C, 018 C, 070 C, 018 C, 
018 C, 018 C, 018 C, 00E C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 018 C, 018 C, 018 C, 018 C, 000 C, 018 C, 
018 C, 018 C, 018 C, 018 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 070 C, 018 C, 018 C, 018 C, 00E C, 018 C, 
018 C, 018 C, 018 C, 070 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 076 C, 0DC C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 010 C, 038 C, 06C C, 0C6 C, 
0C6 C, 0C6 C, 0FE C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 03C C, 066 C, 0C2 C, 0C0 C, 0C0 C, 0C0 C, 
0C2 C, 066 C, 03C C, 00C C, 006 C, 07C C, 000 C, 000 C, 
000 C, 000 C, 0CC C, 0CC C, 000 C, 0CC C, 0CC C, 0CC C, 
0CC C, 0CC C, 0CC C, 076 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 00C C, 018 C, 030 C, 000 C, 07C C, 0C6 C, 0FE C, 
0C0 C, 0C0 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 010 C, 038 C, 06C C, 000 C, 078 C, 00C C, 07C C, 
0CC C, 0CC C, 0CC C, 076 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0CC C, 0CC C, 000 C, 078 C, 00C C, 07C C, 
0CC C, 0CC C, 0CC C, 076 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 060 C, 030 C, 018 C, 000 C, 078 C, 00C C, 07C C, 
0CC C, 0CC C, 0CC C, 076 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 038 C, 06C C, 038 C, 000 C, 078 C, 00C C, 07C C, 
0CC C, 0CC C, 0CC C, 076 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 03C C, 066 C, 060 C, 060 C, 
066 C, 03C C, 00C C, 006 C, 03C C, 000 C, 000 C, 000 C, 
000 C, 010 C, 038 C, 06C C, 000 C, 07C C, 0C6 C, 0FE C, 
0C0 C, 0C0 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0C6 C, 0C6 C, 000 C, 07C C, 0C6 C, 0FE C, 
0C0 C, 0C0 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 060 C, 030 C, 018 C, 000 C, 07C C, 0C6 C, 0FE C, 
0C0 C, 0C0 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 066 C, 066 C, 000 C, 038 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 03C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 018 C, 03C C, 066 C, 000 C, 038 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 03C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 060 C, 030 C, 018 C, 000 C, 038 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 03C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 0C6 C, 0C6 C, 010 C, 038 C, 06C C, 0C6 C, 0C6 C, 
0FE C, 0C6 C, 0C6 C, 0C6 C, 000 C, 000 C, 000 C, 000 C, 
038 C, 06C C, 038 C, 000 C, 038 C, 06C C, 0C6 C, 0C6 C, 
0FE C, 0C6 C, 0C6 C, 0C6 C, 000 C, 000 C, 000 C, 000 C, 
018 C, 030 C, 060 C, 000 C, 0FE C, 066 C, 060 C, 07C C, 
060 C, 060 C, 066 C, 0FE C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0CC C, 076 C, 036 C, 
07E C, 0D8 C, 0D8 C, 06E C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 03E C, 06C C, 0CC C, 0CC C, 0FE C, 0CC C, 
0CC C, 0CC C, 0CC C, 0CE C, 000 C, 000 C, 000 C, 000 C, 
000 C, 010 C, 038 C, 06C C, 000 C, 07C C, 0C6 C, 0C6 C, 
0C6 C, 0C6 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0C6 C, 0C6 C, 000 C, 07C C, 0C6 C, 0C6 C, 
0C6 C, 0C6 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 060 C, 030 C, 018 C, 000 C, 07C C, 0C6 C, 0C6 C, 
0C6 C, 0C6 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 030 C, 078 C, 0CC C, 000 C, 0CC C, 0CC C, 0CC C, 
0CC C, 0CC C, 0CC C, 076 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 060 C, 030 C, 018 C, 000 C, 0CC C, 0CC C, 0CC C, 
0CC C, 0CC C, 0CC C, 076 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 0C6 C, 0C6 C, 000 C, 0C6 C, 0C6 C, 0C6 C, 
0C6 C, 0C6 C, 0C6 C, 07E C, 006 C, 00C C, 078 C, 000 C, 
000 C, 0C6 C, 0C6 C, 000 C, 038 C, 06C C, 0C6 C, 0C6 C, 
0C6 C, 0C6 C, 06C C, 038 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 0C6 C, 0C6 C, 000 C, 0C6 C, 0C6 C, 0C6 C, 0C6 C, 
0C6 C, 0C6 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 018 C, 018 C, 03C C, 066 C, 060 C, 060 C, 060 C, 
066 C, 03C C, 018 C, 018 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 038 C, 06C C, 064 C, 060 C, 0F0 C, 060 C, 060 C, 
060 C, 060 C, 0E6 C, 0FC C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 066 C, 066 C, 03C C, 018 C, 07E C, 018 C, 
07E C, 018 C, 018 C, 018 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 0F8 C, 0CC C, 0CC C, 0F8 C, 0C4 C, 0CC C, 0DE C, 
0CC C, 0CC C, 0CC C, 0C6 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 00E C, 01B C, 018 C, 018 C, 018 C, 07E C, 018 C, 
018 C, 018 C, 018 C, 018 C, 0D8 C, 070 C, 000 C, 000 C, 
000 C, 018 C, 030 C, 060 C, 000 C, 078 C, 00C C, 07C C, 
0CC C, 0CC C, 0CC C, 076 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 00C C, 018 C, 030 C, 000 C, 038 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 03C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 018 C, 030 C, 060 C, 000 C, 07C C, 0C6 C, 0C6 C, 
0C6 C, 0C6 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 018 C, 030 C, 060 C, 000 C, 0CC C, 0CC C, 0CC C, 
0CC C, 0CC C, 0CC C, 076 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 076 C, 0DC C, 000 C, 0DC C, 066 C, 066 C, 
066 C, 066 C, 066 C, 066 C, 000 C, 000 C, 000 C, 000 C, 
076 C, 0DC C, 000 C, 0C6 C, 0E6 C, 0F6 C, 0FE C, 0DE C, 
0CE C, 0C6 C, 0C6 C, 0C6 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 03C C, 06C C, 06C C, 03E C, 000 C, 07E C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 038 C, 06C C, 06C C, 038 C, 000 C, 07C C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 030 C, 030 C, 000 C, 030 C, 030 C, 060 C, 
0C0 C, 0C6 C, 0C6 C, 07C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 0FE C, 0C0 C, 
0C0 C, 0C0 C, 0C0 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 0FE C, 006 C, 
006 C, 006 C, 006 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 0C0 C, 0C0 C, 0C2 C, 0C6 C, 0CC C, 018 C, 030 C, 
060 C, 0CE C, 093 C, 006 C, 00C C, 01F C, 000 C, 000 C, 
000 C, 0C0 C, 0C0 C, 0C2 C, 0C6 C, 0CC C, 018 C, 030 C, 
066 C, 0CE C, 09A C, 03F C, 006 C, 00F C, 000 C, 000 C, 
000 C, 000 C, 018 C, 018 C, 000 C, 018 C, 018 C, 018 C, 
03C C, 03C C, 03C C, 018 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 033 C, 066 C, 0CC C, 
066 C, 033 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0CC C, 066 C, 033 C, 
066 C, 0CC C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
011 C, 044 C, 011 C, 044 C, 011 C, 044 C, 011 C, 044 C, 
011 C, 044 C, 011 C, 044 C, 011 C, 044 C, 011 C, 044 C, 
055 C, 0AA C, 055 C, 0AA C, 055 C, 0AA C, 055 C, 0AA C, 
055 C, 0AA C, 055 C, 0AA C, 055 C, 0AA C, 055 C, 0AA C, 
0DD C, 077 C, 0DD C, 077 C, 0DD C, 077 C, 0DD C, 077 C, 
0DD C, 077 C, 0DD C, 077 C, 0DD C, 077 C, 0DD C, 077 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 0F8 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 0F8 C, 018 C, 0F8 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 0F6 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 0FE C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0F8 C, 018 C, 0F8 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 0F6 C, 006 C, 0F6 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0FE C, 006 C, 0F6 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 0F6 C, 006 C, 0FE C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 0FE C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 0F8 C, 018 C, 0F8 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 0F8 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 01F C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 0FF C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 0FF C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 01F C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 0FF C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 0FF C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 01F C, 018 C, 01F C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 037 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 037 C, 030 C, 03F C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 03F C, 030 C, 037 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 0F7 C, 000 C, 0FF C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0FF C, 000 C, 0F7 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 037 C, 030 C, 037 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0FF C, 000 C, 0FF C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 0F7 C, 000 C, 0F7 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 0FF C, 000 C, 0FF C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 0FF C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0FF C, 000 C, 0FF C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 0FF C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 03F C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 01F C, 018 C, 01F C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 01F C, 018 C, 01F C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 03F C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 0FF C, 
036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 036 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 0FF C, 018 C, 0FF C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 0F8 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 01F C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 
0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 0FF C, 
0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 
0F0 C, 0F0 C, 0F0 C, 0F0 C, 0F0 C, 0F0 C, 0F0 C, 0F0 C, 
0F0 C, 0F0 C, 0F0 C, 0F0 C, 0F0 C, 0F0 C, 0F0 C, 0F0 C, 
00F C, 00F C, 00F C, 00F C, 00F C, 00F C, 00F C, 00F C, 
00F C, 00F C, 00F C, 00F C, 00F C, 00F C, 00F C, 00F C, 
0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 0FF C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 076 C, 0DC C, 0D8 C, 
0D8 C, 0D8 C, 0DC C, 076 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 0FC C, 0C6 C, 0FC C, 
0C6 C, 0C6 C, 0FC C, 0C0 C, 0C0 C, 0C0 C, 000 C, 000 C, 
000 C, 000 C, 0FE C, 0C6 C, 0C6 C, 0C0 C, 0C0 C, 0C0 C, 
0C0 C, 0C0 C, 0C0 C, 0C0 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 080 C, 0FE C, 06C C, 06C C, 
06C C, 06C C, 06C C, 06C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 0FE C, 0C6 C, 060 C, 030 C, 018 C, 
030 C, 060 C, 0C6 C, 0FE C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 07E C, 0D8 C, 0D8 C, 
0D8 C, 0D8 C, 0D8 C, 070 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 066 C, 066 C, 066 C, 066 C, 
066 C, 07C C, 060 C, 060 C, 0C0 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 076 C, 0DC C, 018 C, 018 C, 
018 C, 018 C, 018 C, 018 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 07E C, 018 C, 03C C, 066 C, 066 C, 
066 C, 03C C, 018 C, 07E C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 038 C, 06C C, 0C6 C, 0C6 C, 0FE C, 
0C6 C, 0C6 C, 06C C, 038 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 038 C, 06C C, 0C6 C, 0C6 C, 0C6 C, 06C C, 
06C C, 06C C, 06C C, 0EE C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 01E C, 030 C, 018 C, 00C C, 03E C, 066 C, 
066 C, 066 C, 066 C, 03C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 07E C, 0DB C, 0DB C, 
0DB C, 07E C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 003 C, 006 C, 07E C, 0CF C, 0DB C, 
0F3 C, 07E C, 060 C, 0C0 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 01C C, 030 C, 060 C, 060 C, 07C C, 060 C, 
060 C, 060 C, 030 C, 01C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 07C C, 0C6 C, 0C6 C, 0C6 C, 0C6 C, 
0C6 C, 0C6 C, 0C6 C, 0C6 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 0FE C, 000 C, 000 C, 0FE C, 
000 C, 000 C, 0FE C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 018 C, 018 C, 07E C, 018 C, 
018 C, 000 C, 000 C, 0FF C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 030 C, 018 C, 00C C, 006 C, 00C C, 
018 C, 030 C, 000 C, 07E C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 00C C, 018 C, 030 C, 060 C, 030 C, 
018 C, 00C C, 000 C, 07E C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 00E C, 01B C, 01B C, 018 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 018 C, 
0D8 C, 0D8 C, 0D8 C, 070 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 018 C, 018 C, 000 C, 07E C, 
000 C, 018 C, 018 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 076 C, 0DC C, 000 C, 
076 C, 0DC C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 038 C, 06C C, 06C C, 038 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 018 C, 
018 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
018 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 00F C, 00C C, 00C C, 00C C, 00C C, 00C C, 0EC C, 
06C C, 06C C, 03C C, 01C C, 000 C, 000 C, 000 C, 000 C, 
000 C, 0D8 C, 06C C, 06C C, 06C C, 06C C, 06C C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 070 C, 098 C, 030 C, 060 C, 0C8 C, 0F8 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 07C C, 07C C, 07C C, 07C C, 
07C C, 07C C, 07C C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 000 C, 
decimal
