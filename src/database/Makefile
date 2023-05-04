ifeq ($(OS), Windows_NT)
	#Windows
	RM := del /q
else 
	#macOS
	RM := rm -f
endif

CPP = g++

all : example

example: example.o gamesDB.o
	$(CPP) -o example example.o gamesDB.o

example.o: example.cpp gamesDB.h dbObjects.h
	$(CPP) -c example.cpp

gamesDB.o: gamesDB.cpp gamesDB.h dbObjects.h
	$(CPP) -c gamesDB.cpp

clean:
	$(RM) example *.o