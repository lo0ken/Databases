using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator_v._2.Generators
{
    public abstract class GeneratorBase<T> where T : class
    {
        protected static Random random = new Random();

        private int id;
        private readonly int size;
        private readonly T[] entities;

        public GeneratorBase(int size)
        {
            id = 1;
            this.size = size;
            entities = new T[size];
        }

        public T[] Generate()
        {
            for (int i = 0; i < size; i++)
                entities[i] = MakeItem();

            return entities;
        }

        protected int GetId()
        {
            return id++;
        }

        protected abstract T MakeItem();
    }
}
