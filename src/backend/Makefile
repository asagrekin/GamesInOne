ifeq ($(OS), Windows_NT)
	#Windows
	RM := del /q
else 
	#macOS
	RM := rm -f
endif
CC = g++
CFLAGS = -Wall -Wextra -std=c++11

SOURCES = demo.cpp gamelauncher.cpp ..\database\gamesDB.cpp
HEADERS = gamelauncher.h ..\database\gamesDB.h ..\database\dbObjects.h

OBJECTS = $(SOURCES:.cpp=.o)

TARGET = demo.exe

$(TARGET): $(OBJECTS)
	$(CC) $(CFLAGS) -o $@ $^

%.o: %.cpp $(HEADERS)
	$(CC) $(CFLAGS) -c -o $@ $<

clean:
	$(RM) $(OBJECTS) $(TARGET)