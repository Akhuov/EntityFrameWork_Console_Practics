using NTT_FrameWork;
using NTT_FrameWork.DataBase;
using NTT_FrameWork.Models;

var db = new UserDB();
UpdateUser(1);
Add();
void Add()
{
    
    db.Users.Add(new User()
    {
       name = "Aziz",
       PhoneNumber = "1234-1234-1234",

        });
    db.SaveChanges(); 
    Console.WriteLine("Added");
}

void UpdateUser(int userId)
{
    var user = db.Users.FirstOrDefault(user => user.userId == userId);
    user.name = "Sirojjidin";
    db.Users.Update(user);
    db.SaveChanges();
}

//UserViewModel GetUser(int userId)
//{
//    var user = db.Users.FirstOrDefault(user => user.userId == userId);
//    return new UserViewModel()
//    {
//        UserId = user.userId
//    }
//}

//void DeleteUser() HomeWork
//{

//}