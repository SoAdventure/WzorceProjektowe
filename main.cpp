#include <iostream>;
#include <string>;
using namespace std;


// podstawowe ciacho
class Ciastko {
protected:
		string ciastko;
		double koszt;
public:
	Ciastko() {
		ciastko = "Standardowe ciacho";
		koszt = 0;  }

	virtual string info() {
		return ciastko;
		}

	virtual double cena() {
		return koszt;
		}
};
//dekorator
class Dekorator : public Ciastko {
public:
	virtual string info() {
		return "Duże ciastko";
	}
};
//Smaki ciastek
class Czekolada : public Ciastko {

public: Czekolada() :Ciastko() {
		ciastko = "Czekoladowe ciacho ";
		koszt = 3.50;
	}
};
class Waniliowe : public Ciastko {

public:
	Waniliowe() :Ciastko() {
		ciastko = "Waniliowe ciacho ";
		koszt = 3.50;
	}
};
//dodatki
class Dodatki : public Dekorator {
	Ciastko *cookie;

public: Dodatki(Ciastko *ciastko) :Dekorator() {
	cookie = ciastko;
}

		string info() {
			return cookie->info() + " Dodatki do ciacha";
	}
		double cena() {
			return cookie->cena() + 0.50;
		}
};
class Polewy : public Dekorator {
	Ciastko *cookie;

public: Polewy(Ciastko *ciastko) :Dekorator() {
	cookie = ciastko;
}
		string info() {
			return cookie->info() + " Polewa do ciacha ";
		}

		double cena() {
			return cookie->cena() + 0.50;
		}
};
int main() {
    Ciastko *Ciacho1 = new Czekolada();
	Ciastko *Ciacho2 = new Waniliowe();
	cout << Ciacho1->info() << " " << Ciacho1->cena()<< endl;
	cout << Ciacho2->info() << " " << Ciacho2->cena()<< endl;
	Ciacho1 = new Dodatki(Ciacho1);
	Ciacho2 = new Dodatki(Ciacho2);
    Ciacho2 = new Polewy(Ciacho2);
	cout << Ciacho1->info() << " " << Ciacho1->cena()<< endl;
	cout << Ciacho2->info() << " " << Ciacho2->cena()<< endl;

}

