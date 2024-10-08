using Microsoft.EntityFrameworkCore;

public class Context : DbContext  
{  


    public DbSet<Product> Products { get; set; } // جدول محصولات  
    public DbSet<Users> Users { get; set; }       // جدول کاربران  

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer("server=.\\SQL2019;database=IliaForm;trusted_connection=true;MultipleActiveResultSets=True;TrustServerCertificate=True");
        optionsBuilder.UseSqlServer("server=DEVELOPER2;database=IliaForm11;user ID=sa;password=12345@Iran;MultipleActiveResultSets=True;TrustServerCertificate=True");
                
    }
}
