NewClass.AccInfo("atchi", "213asd", "213asd");
public class NewClass
{
    
     public static bool AccInfo(string login,string password,string confirmPass)
    {
        try
        {
            if (login.Length < 20 & !login.Contains(' '))
            {
               
            }
            else
            {
                
                if (login.Length>20)
                {
                    throw new WrongLoginExceptation("Write correct login");

                }

                if(login.Contains(' '))
                {
                    throw new WrongLoginExceptation("Write login without space");
                }
            }
            if(password.Length <20 & password.Any(Char.IsDigit) & !password.Contains(' ') &password==confirmPass)          
            {
               
            }
            else
            {
                if (password.Length>20)
                {
                    throw new WrongLoginExceptation("bad length of password ");
                }
                if (!password.Any(Char.IsDigit))
                {
                    throw new WrongPassworException("Write password with digit");
                }
                if (password.Contains(' '))
                {
                    throw new WrongPassworException("Write password without space");
                }
                if (confirmPass != password)
                {
                    throw new WrongPassworException("Password not equals with Password ");
                }
            }
        }
        catch (WrongLoginExceptation ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(WrongPassworException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return true;

    }
    
}
public class WrongLoginExceptation :Exception
{
    public WrongLoginExceptation() : base() { }
    public WrongLoginExceptation(string message) : base(message) { }
}
public class WrongPassworException : Exception
{
    public WrongPassworException():base() { }
    public WrongPassworException(string message) : base(message) { }
}



