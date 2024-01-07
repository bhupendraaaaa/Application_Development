using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Linq;
using System.Text;
using MauiApp1.Data;
namespace MauiApp1.NewFolder
{
    public class User
    {
        private List<WorkerPage> userList = new()
        {
            new WorkerPage()
            {
                Password = "admin",
                Role = "admin",
            },

            new WorkerPage()
            {
                Password = "staff",
                Role = "staff"
            }
        };

        public WorkerPage LoginWorker(string password)
        {
            WorkerPage worker = userList.FirstOrDefault(w => w.Password == password);

            if (worker == null)
            {
                throw new Exception("Invalid Password");
            }

            return worker;
        }
    }
}
