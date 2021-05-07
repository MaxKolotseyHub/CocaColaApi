using CocaColaDal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocaColaDal.Context
{
    public class CocaColaInitializer : DropCreateDatabaseIfModelChanges<CocaColaContext>
    {
        protected override void Seed(CocaColaContext context)
        {
            base.Seed(context);

            var user1 = new User { Email = "nasty_nastya@gmail.com", FirstName="Анастасия", LastName="Крылова" };
            var user2 = new User { Email = "spongebob@gmail.com", FirstName="Спанч", LastName="Боб" };
            var user3 = new User { Email = "vladislove@gmail.com", FirstName="Владислав", LastName="Петров" };
            var user4 = new User { Email = "maxislav@gmail.com", FirstName="Максим", LastName="Савичев" };
            var user5 = new User { Email = "wannawin@gmail.com", FirstName="Дмитрий", LastName="Ополько" };
            var user6 = new User { Email = "villy_wonka@gmail.com", FirstName="Илья", LastName="Соболь" };
            var user7 = new User { Email = "pewdiepie@gmail.com", FirstName="Пьюди", LastName="Пай" };
            var user8 = new User { Email = "steve_wonder@gmail.com", FirstName="Степан", LastName="Созонов" };
            var user9 = new User { Email = "goldendog@gmail.com", FirstName="Николай", LastName="Федотов" };
            var user10 = new User { Email = "hugeboss@gmail.com", FirstName="Василий", LastName="Викторчук" };
            var user11 = new User { Email = "hacker2003@gmail.com", FirstName="Михаил", LastName="Конопацкий" };
            var user12 = new User { Email = "holdmybeer@gmail.com", FirstName="Артем", LastName="Симаков" };
            var user13 = new User { Email = "valarmorgulis@gmail.com", FirstName="Константин", LastName="Орловский" };
            var user14 = new User { Email = "jonasbrothers@gmail.com", FirstName="Никита", LastName="Живицкий" };
            var user15 = new User { Email = "putinist@gmail.com", FirstName="Андрей", LastName="Ухтинский" };

            context.Users.AddRange(new List<User> {user1, user2, user3, user4, user5, user6, user7, user8, user9, user10, user11, user12, user13, user14, user15 });

            var code1 = new Code {Title = "QHR0001", Used = true, User = user1 };
            var code2 = new Code {Title = "QHR0002", Used = true, User = user2 };
            var code3 = new Code {Title = "QHR0003", Used = true, User = user3 };
            var code4 = new Code {Title = "QHR0004", Used = true, User = user4 };
            var code5 = new Code {Title = "QHR0005", Used = true, User = user5 };
            var code6 = new Code {Title = "QHR0006", Used = true, User = user6 };
            var code7 = new Code {Title = "QHR0007", Used = true, User = user7 };
            var code8 = new Code {Title = "QHR0008", Used = true, User = user8 };
            var code9 = new Code {Title = "QHR0009", Used = true, User = user9 };
            var code10 = new Code {Title = "QHR00010", Used = true, User = user10 };
            var code11 = new Code {Title = "QHR00011", Used = true, User = user11 };
            var code12 = new Code {Title = "QHR00012", Used = true, User = user12 };
            var code13 = new Code {Title = "QHR00013", Used = true, User = user13 };
            var code14= new Code {Title = "QHR00014", Used = true, User = user14 };
            var code15 =  new Code {Title = "QHR00015", Used = true, User = user15 };

            context.Codes.AddRange(new List<Code> { code1, code2, code3, code4, code5, code6, code7, code8, code9, code10, code11, code12, code13, code14, code15});

            context.SaveChanges();
        }
    }
}
