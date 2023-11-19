namespace DZ_c_dies_772
{
    internal class Program
    {
        static public int Prevr(Money M)
        {
            int S = M.Rub * 100 + M.Kop;
            return S;
        }
        static public Money Prevr(int K)
        {
            int a1 = 0, a2 = 0;
            a1 = K / 100;
            a2 = K % 100;
            Money H = new Money(a1, a2);
            return H;
        }
        public class Money
        {
            public int Rub { get; set; }
            public int Kop { get; set; }
            public Money(int r, int k) { Rub = r; Kop = k; }
            public Money() { Rub = 0; Kop = 0; }
            public bool Prov()
            {
                if (Rub < 0) { throw new Exception(" Банкрот ");  }
                else { return true; }
                
            }
            public void Kpeechka()
            {
                if (Kop >= 100)
                {
                    int a = Kop / 100;
                    Kop = Kop % 100;
                    Rub += a;
                }
            }
            public void Mostra() { Console.WriteLine(" Рублей " + Rub + " Копеек " + Kop); }

            public static Money operator +(Money M, Money M2)
            {
                int G = Prevr(M) + Prevr(M2);
                Money H = Prevr(G);
                H.Prov();
                return H;
            }
            public static Money operator -(Money M, Money M2)
            {
                int G = Prevr(M) - Prevr(M2);
                Money H = Prevr(G);
                H.Prov();
                return H;
            }
            public static Money operator /(Money M, Money M2)
            {
                int G = Prevr(M) / Prevr(M2);
                Money H = Prevr(G);
                H.Prov();
                return H;
            }
            public static Money operator *(Money M, Money M2)
            {
                int G = Prevr(M) * Prevr(M2);
                Money H = Prevr(G);
                H.Prov();
                return H;
            }
            public static bool operator ==(Money M, Money M2)
            {              
                return Prevr(M) == Prevr(M2);
            }
            public static bool operator !=(Money M, Money M2)
            {
                return Prevr(M) != Prevr(M2);
            }
            public static Money operator ++(Money M2)
            {
                int S=Prevr(M2);
                S++;
                var MK=Prevr(S);
                MK.Prov();
                return MK;

            }
            public static Money operator --(Money M2)
            {
                int S = Prevr(M2);
                S--;
                var MK = Prevr(S);
                MK.Prov();
                return MK;
            }
            public static bool operator <(Money M, Money M2)
            {
                return Prevr(M) < Prevr(M2);
            }
            public static bool operator >(Money M, Money M2)
            {
                return Prevr(M) < Prevr(M2);
            }
        }
        static void Main(string[] args)
        {
            Money MMM = new Money(200, 20);
            Money PPP = new Money(400, 40);
            Money B = new Money();
            try
            {
                B.Mostra();
                B = MMM - PPP;
            }
            catch(Exception e) { Console.WriteLine(e.Message); }
            B = MMM * PPP; B.Mostra();
            B = PPP / MMM; B.Mostra();
            B++;B.Mostra();
        }
    }
}