### Variablen
# Compiler
CC = g++

# Optionen für Compiler
CFLAGS = -c
#CFLAGS = -I/usr/include/python3.3m -I/usr/include/python3.3m -Wno-unused-result -DDYNAMIC_ANNOTATIONS_ENABLED=1 -DNDEBUG -g -fwrapv -O3 -Wall -Wstrict-prototypes -march=x86-64 -mtune=generic -O2 -pipe -fstack-protector --param=ssp-buffer-size=4 -march=x86-64 -mtune=generic -O2 -pipe -fstack-protector --param=ssp-buffer-size=4 -c

# Optionen für Linker
#ILINK = -I/usr/include/python3.3 -lpython3.3
#ILINK = -lpthread -ldl -lutil -lm -lpython3.3m -Xlinker -export-dynamic

# Objekte
OBJ = main.o directory.o fsint.o

# Verzeichnisse
ODIR = build
SDIR = src



### Make-Anweisungen

all: legion

legion: $(OBJ)
	$(CC) $(ODIR)/main.o $(ODIR)/directory.o $(ODIR)/fsint.o -o legion

%.o: $(SDIR)/%.cpp
	$(CC) $(CFLAGS) $< -o $(ODIR)/$@

clean:
	rm -rf $(ODIR)/* legion
