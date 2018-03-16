# Makefile based on the Makefile provided by Lazyfoo's tutorials
# http://lazyfoo.net/tutorials/SDL/01_hello_SDL/index.php

#OBJS specifies which files to compile as part of the project
OBJS = code/main.cpp code/engine/*.cpp

#CC specifies which compiler we're using
CC = g++

#INCLUDE_PATHS specifies the additional include paths we'll need
INCLUDE_PATHS = -I${CURDIR}/lib/SDL/include/SDL2 -I${CURDIR}/lib/SDL_Image/include/SDL2 -I${CURDIR}/code/engine

#LIBRARY_PATHS specifies the additional library paths we'll need
LIBRARY_PATHS = -L${CURDIR}/lib/SDL/lib -L${CURDIR}/lib/SDL_Image/lib

#COMPILER_FLAGS specifies the additional compilation options we're using
# -w suppresses all warnings
# -Wl,-subsystem,windows gets rid of the console window
COMPILER_FLAGS = -w -Wl,-subsystem,windows -g

#LINKER_FLAGS specifies the libraries we're linking against
LINKER_FLAGS = -lmingw32 -lSDL2main -lSDL2 -lSDL2_image

#OBJ_NAME specifies the name of our exectuable
OBJ_NAME = bin/main
#This is the target that compiles our executable
all : $(OBJS)
	$(CC) $(OBJS) $(INCLUDE_PATHS) $(LIBRARY_PATHS) $(COMPILER_FLAGS) $(LINKER_FLAGS) -o $(OBJ_NAME)