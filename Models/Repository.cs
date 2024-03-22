namespace MeetingApp.Models
{
    public static class Repository
    {
        //sadece bu sayfada kullanılacak olan bir _users objesi oluşturuyoruz.
        private static List<UserInfo> _users = new();
        //construct metodu ekleniyor.
        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Muhammed", Phone = "54333848484", Email = "abc.@gmail.com", WillAtend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Ayşe", Phone = "54384843334", Email = "abcd.@gmail.com", WillAtend = false });
            _users.Add(new UserInfo() { Id = 3, Name = "Fatma", Phone = "54384848333", Email = "abcs.@gmail.com", WillAtend = false });
            _users.Add(new UserInfo() { Id = 4, Name = "Hayriye", Phone = "54384848433", Email = "abcs.@gmail.com", WillAtend = true });
        }
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }
        public static void CreateUser(UserInfo user)
        {
            user.Id = _users.Count + 1;
            _users.Add(user);
        }
        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}