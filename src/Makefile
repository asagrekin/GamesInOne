ifeq ($(OS), Windows_NT)
	#Windows
	RM := del /q
else 
	#macOS
	RM := rm -f
endif

CPP=g++
CPPFLAGS=-Wall -g

OBJFILES=gamelauncher.o

gamelauncher: $(OBJFILES)
	$(CPP) $(CPPFLAGS) $(OBJFILES) -o gamelauncher

gamelauncher.o: gamelauncher.cpp gamelauncher.h
	$(CPP) $(CPPFLAGS) -c gamelauncher.cpp

clean:
	$(RM) $(OBJFILES) gamelauncher.exe