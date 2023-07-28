using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    public class Shop:IEnumerable<Product>
    {
        private Product[] Products = 
            {
        new Product{Name ="Prod1"},
         new Product{Name ="Prod2"},
          new Product{Name ="Prod3"},

        };
        
        public string Name { get; set; }
        public string Category { get; set; }

        

        public Shop(string Name, string Category)
        {
            this.Category = Category;
            this.Name = Name;
        }

        public IEnumerator<Product> GetEnumerator()
        {
            return new ProductEnumerator(Products);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class ProductEnumerator : IEnumerator<Product>
    {
        public ProductEnumerator(Product[] source)
        {
            this.source = source;
        }
        private Product[] source;
        private int _index = -1;
        public Product Current
        {
            get
            {
                return source[_index];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

       

        public bool MoveNext()
        {
            if(_index %2==0)
            {
                string a = "";
            }
            _index++;
            return _index < source.Length;
        }

        public void Reset()
        {
            _index = -1;
        }


        public void Dispose()
        {
            // unmaged clean
        }
    }

}
