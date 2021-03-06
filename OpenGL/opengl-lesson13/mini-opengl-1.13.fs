\ ===================================================================
\           File: mini-opengl-1.13.fs
\         Author: Timothy Trussell
\           Date: 07/31/2010
\    Description: OpenGL libcc interface for NeHe OpenGL Tutorial 13
\   Forth System: gforth-0.7.0
\      Assembler: Built-in FORTH assembler
\   Linux System: Ubuntu v10.04 LTS i386, kernel 2.6.31-24
\   C++ Compiler: gcc version 4.4.3 (Ubuntu 4.4.3-4ubuntu5)
\ ===================================================================
\ This libcc interface contains the cumulatively added OpenGL code
\ function calls that are required for use with the gforth version of
\ the NeHe OpenGL Tutorial Lessons.
\ ===================================================================

UseLibUtil [if]
  c-library mini_opengl_lib
[else]
  c-library mini_opengl_lib13
[then]

s" GL" add-lib
s" GLU" add-lib

\c #if defined(__APPLE__) && defined(__MACH__)
\c      #include <OpenGL/gl.h>
\c      #include <OpenGL/glu.h>
\c      #include <OpenGL/glx.h>
\c #else
\c      #include <GL/gl.h>
\c      #include <GL/glu.h>
\c      #include <GL/glx.h>
\c #endif

\ Initial Entries for Lesson 01
c-function gl-clear            glClear                      n -- void
c-function gl-clear-color      glClearColor           r r r r -- void
c-function gl-clear-depth      glClearDepth                 r -- void
c-function gl-enable           glEnable                     n -- void
c-function gl-depth-func       glDepthFunc                  n -- void
c-function gl-hint             glHint                     n n -- void
c-function gl-load-identity    glLoadIdentity                 -- void
c-function gl-matrix-mode      glMatrixMode                 n -- void
c-function gl-shade-model      glShadeModel                 n -- void
c-function gl-viewport         glViewport             n n n n -- void
c-function glu-perspective     gluPerspective         r r r r -- void

\ Additions for Lesson 02
c-function gl-begin            glBegin                      n -- void
c-function gl-end              glEnd                          -- void
c-function gl-translate-f      glTranslatef             r r r -- void
c-function gl-vertex-3f        glVertex3f               r r r -- void

\ Additions for Lesson 03
c-function gl-color-3f         glColor3f                r r r -- void

\ Additions for Lesson 04
c-function gl-rotate-f         glRotatef              r r r r -- void

\ Additions for Lesson 05
\ -- none

\ Additions for Lesson 06
c-function gl-bind-texture     glBindTexture              n n -- void
c-function gl-gen-textures     glGenTextures              n a -- void
c-function gl-tex-coord-2f     glTexCoord2f               r r -- void
c-function gl-tex-image-2d     glTexImage2D n n n n n n n n a -- void
c-function gl-tex-parameter-i  glTexParameteri          n n n -- void

\ Additions for Lesson 07
c-function gl-disable          glDisable                    n -- void
c-function gl-light-fv         glLightfv                n n a -- void
c-function gl-normal-3f        glNormal3f               r r r -- void
c-function glu-build-2d-mipmaps gluBuild2DMipmaps n n n n n n a -- void

\ Additions for Lesson 08
c-function gl-blend-func       glBlendFunc                n n -- void
c-function gl-color-4f         glColor4f              r r r r -- void

\ Additions for Lesson 09
c-function gl-color-4ub        glColor4ub             n n n n -- void

\ Additions for Lesson 10
\ -- none

\ Additions for Lesson 11
c-function gl-polygon-mode     glPolygonMode              n n -- void

\ Additions for Lesson 12
c-function gl-call-list        glCallList                   n -- void
c-function gl-color-3fv        glColor3fv                   a -- void
c-function gl-end-list         glEndList                      -- void
c-function gl-gen-lists        glGenLists                      n -- n
c-function gl-new-list         glNewList                  n n -- void

\ Additions for Lesson 13
c-function gl-call-lists       glCallLists              n n a -- void
c-function gl-delete-lists     glDeleteLists              n n -- void
c-function gl-list-base        glListBase                   n -- void
c-function gl-pop-attrib       glPopAttrib                    -- void
c-function gl-push-attrib      glPushAttrib                 n -- void
c-function gl-raster-pos-2f    glRasterPos2f              r r -- void
c-function gl-xusexfont        glXUseXFont            n n n n -- void
c-function x-closedisplay      XCloseDisplay                   a -- n
c-function x-freefont          XFreeFont                     a a -- n
c-function x-loadqueryfont     XLoadQueryFont                a a -- a
c-function x-opendisplay       XOpenDisplay                    a -- a

end-c-library

include glconstants.fs

