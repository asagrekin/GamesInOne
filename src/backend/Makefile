ifeq ($(OS), Windows_NT)
	#Windows
	RM := del /q
else 
	#macOS
	RM := rm -f
endif
CC = g++
CFLAGS = -Wall -Wextra -std=c++11

SOURCES = gamelauncher.cpp gamesDB.cpp
HEADERS = gamelauncher.h gamesDB.h dbObjects.h

OBJECTS = $(SOURCES:.cpp=.o)

TARGET = gamelauncher.exe

$(TARGET): $(OBJECTS)
	$(CC) $(CFLAGS) -o $@ $^

%.o: %.cpp $(HEADERS)
	$(CC) $(CFLAGS) -c -o $@ $<

clean:
	$(RM) $(OBJECTS) $(TARGET)
