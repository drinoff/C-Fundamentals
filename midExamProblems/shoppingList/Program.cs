
using System;
using System.Collections.Generic;
using System.Linq;
 
namespace ExamPrepShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split("!").ToList();   // splitvame Lista po udivitelni - !

            var input = Console.ReadLine();   // priemame parvata komanda ot konzolata kqoto moje da bade Urgent, i t.n.

            while (input!="Go Shopping!")    // dokato vhoda ot konzolata e razlichen ot Go Shopping! = prawi bloka ot Kod
            {
                var command = input.Split().ToArray();    // splitvam vhoda s komandi i go zapazvam v "command"
                var action = command[0];                  // wzimam samo parviqt splitnat element poneje drugite shte gi gledam posle. vzimam towa samo za preglednost i zashtoto shte vartq nego
                switch (action)
                {
                    case "Urgent":
                        var item = command[1];           // vzimam veche tuk kakvoto mi trqbva , na mene taka mi izglejda po prilejno
                        if (!list.Contains(item))        // ako lista NE sadarja itema pravi bloka kod
                        {
                            list.Insert(0,item);        // pogledni v Google kakvo pravi Insert().
                        }                              // ako itema e v lista ne pravq nishto... nqma nujkda ot else i continue
                        break;
                    case "Unnecessary":
                        item = command[1];            // tuka si vzimam pak itema , no nqma var otpred. prosto kazvam ti si raven na tova . Nqma var poneje gore veche vednaj sam kazal "var item"
                        if (list.Contains(item))
                        {
                            list.Remove(item);      // tuka ti e qsno mislq
                        }                           // tuk pak nqma else... Kato go nema itema go nema tolkoz.skipvash tva sa kazali.
                        break;
                    case "Correct":
                        var oldItem = command[1];
                        var newItem = command[2];      // vzimam si dvata itema ot vhoda
                        if (list.Contains(oldItem))
                        {
                            var index = list.IndexOf(oldItem);   // nameri indeksa na stariq item
                            list[index] = newItem;               // list ot indeksa na stariq item = newItem    prosto prezapisvam stojnostta na noviq item varhu stariq. nqma nujda ot remove
                        }
                        break;
                    case "Rearrange":
                        item = command[1];                   // otnovo samo si vzimam itema ot vhoda
                        if (list.Contains(item))
                        {                           
                            list.Remove(item);         // maham
                            list.Add(item);            // zakacham nakraq sashtiq item
                        }
                        break;
                }
                input = Console.ReadLine();                     // ne zabravqsh pak da poiskash vhod
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}

