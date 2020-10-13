

namespace Övning1
{
    class Resa
    {
        public string namn;
        public string destination;
        public int antalDagar;

        public Resa(string namn, string destination, int antalDagar)
        {
            this.namn = namn;
            this.destination = destination;
            this.antalDagar = antalDagar;
        }

        public override string ToString()
        {
            return $"{destination} i {antalDagar} {(antalDagar == 1 ? "dag" : "dagar")}";
        }
    }
}
