CPP = g++

all : example

example: example.o gamesDB.o
	$(CPP) -o $@ $<

example.o: example.cpp gamesDB.h example.h
	$(CPP) -c $<

gamesDB.o: gamesDB.cpp gamesDB.h example.h
	$(CPP) -c $<

clean:
	rm example *.o *~.