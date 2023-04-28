using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ArrayTimoshka
    {
        private int[] Fot; 

        
        public ArrayTimoshka(int size)
        {
            Fot = new int[size];
        }

        
        public int this[int Index]
        {
            get
            {
                if (Index < 0 || Index >= Fot.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return Fot[Index];
            }
            set
            {
                if (Index < 0 || Index >= Fot.Length)
                
                    throw new IndexOutOfRangeException();
                Fot[Index] = value;
                
            }
        }

        
        public static ArrayTimoshka operator +(ArrayTimoshka X, ArrayTimoshka Y)
        {
            if (X.Fot.Length != Y.Fot.Length)
                throw new ArgumentException("Размерности массивов должны совпадать");
            ArrayTimoshka Resultat = new ArrayTimoshka(X.Fot.Length);
            for (int i = 0; i < X.Fot.Length; i++)
            {
                Resultat[i] = X[i] + Y[i];
            }
            return Resultat;
        }

        
        public static ArrayTimoshka operator -(ArrayTimoshka X, ArrayTimoshka Y)
        {
            if (X.Fot.Length != Y.Fot.Length)
                throw new ArgumentException("Размерности массивов должны совпадать");
            ArrayTimoshka Resultat = new ArrayTimoshka(X.Fot.Length);
            for (int i = 0; i < X.Fot.Length; i++)
            {
                Resultat[i] = X[i] - Y[i];
            }
            return Resultat;
        }

        
        public void Multiply(int NOMER)
        {
            for (int i = 0; i < Fot.Length; i++)
            {
                Fot[i] *= NOMER;
            }
        }


    }
}
