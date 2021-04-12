using MongoRepository;
using MongoRepository.Models;
using System;

namespace MongoDbRepositoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MongoRepository<Model> repository = new MongoRepository<Model>())
            {
                Model model = new Model()
                {
                    Ad = "Fatmaa",
                    Soyad = "Günay"
                };

                //repository.Add(model);                                  //Modeli databas'e ekler.
                //var data = repository.Get(x => x.Soyad == "Günay");     //Verilen koşula göre veri çeker.
                //var datas = repository.GetAll();                        //Tum verileri çeker. -> Foreach'te dönder.
                //var datas = repository.GetAll(x => x.Soyad == "Günay"); //Verilen koşula uyan tüm verileri çeker.
                //repository.Update(x => x.Soyad == "Günay", model);      //Gelen veriyi şarttakine göre değiştirir.
                //repository.Delete(x => x.Ad == "Fatmaa");               //Şarta göre veriyi siler.

            }
        }
    }
}
