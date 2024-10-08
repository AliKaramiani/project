using System.ComponentModel.DataAnnotations;

public class Users
{
    [Key]
public int User_id { get; set; }
public string Name { get; set; }
public string Family { get; set; }
public string UserName { get; set; }
public int PhonUmber { get; set; }
public string password { get; set; }
public string Address { get; set; }

}