using School.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using School.Data.ViewModels;

namespace School.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        StudentViewModel model = new StudentViewModel();



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);



            //builder.Entity<Teacher>().Property(e => e.CreatedAt) 
            //          .HasColumnType("timestamp")
            //          .ValueGeneratedOnAddOrUpdate()
            //          .HasDefaultValueSql("CURRENT_TIMESTAMP");

            //builder.Entity<Teacher>().Property(e => e.UpdatedAt)
            //          .HasColumnType("timestamp")
            //          .ValueGeneratedOnAddOrUpdate()
            //          .HasDefaultValueSql("CURRENT_TIMESTAMP");


            //builder.Entity<AllowModification>().Property(x => x.Id).IsUnicode();
            //builder.Entity<Teacher>().Property(x => x.EmailAddress).IsUnicode();
            //builder.Entity<TeacherClass>().HasKey(d => new { d.ClassId, d.TeacherId });


            builder.Entity<Gender>().HasData(new Gender { Id = 1, Name = "ذكر" },
            new Gender { Id = 2, Name = "أنثى" });

            builder.Entity<CompletionType>().HasData(
                new CompletionType { Id = 1, Name = "إنجاز سريع" },
                new CompletionType { Id = 2, Name = "إنجاز بمساعدة " },
                new CompletionType { Id = 3, Name = "إنجاز بمساعدة " },
                new CompletionType { Id = 4, Name = "لم ينجز" });



            builder.Entity<Semester>().HasData(new Semester { Id = 1, Name = "الفصل الدراسي الأول " },
            new Semester { Id = 2, Name = "الفصل الدراسي الثاني" });


            builder.Entity<Duration>().HasData(new Duration { Id = 1, Name = "الشهر الأول " },
            new Duration { Id = 2, Name = "الشهر الثاني " },
                 new Duration { Id = 3, Name = "الشهر الثالث " },
                      new Duration { Id = 4, Name = "الشهر الرابع " });

            
 

            builder.Entity<Class>().HasData(new Class { Id = 101, Name = " الصف الأول " },
            new Class { Id = 102, Name = " الصف الثاني      " },
            new Class { Id = 103, Name = "  الصف الثالث  " },
            new Class { Id = 104, Name = "   الصف الرابع " },
            new Class { Id = 105, Name = "  الصف الخامس  " },
            new Class { Id = 106, Name = "  الصف السادس  " },
            new Class { Id = 107, Name = "   الصف السابع " },
            new Class { Id = 108, Name = " الصف الثامن" },
            new Class { Id = 109, Name = "   الصف التاسع " },
            new Class { Id = 110, Name = " الصف العاشر " },
            new Class { Id = 111, Name = "   الصف الحادي عشر" } );

            builder
                .Entity<Subject>().HasData(
           // مواد الصف الأول 
           new Subject { Id = 100, Name = " 	لغة عربية  ",            ClassId = 101 , TeacherId= 100 },
           new Subject { Id = 200, Name = "  لغة انجليزية  ",          ClassId = 101, TeacherId = 500 },
           new Subject { Id = 300, Name = "تربية وطنية وحياتية ",      ClassId = 101, TeacherId = 100 },
           new Subject { Id = 400, Name = " تربية إسلامية ",            ClassId = 101, TeacherId = 100 },
           new Subject { Id = 500, Name = " 	حاسوب  ",                ClassId = 101, TeacherId = 100 },
           new Subject { Id = 600, Name = "الرياضيات",                 ClassId = 101, TeacherId = 100 },
           // مواد الصف الثاني

           new Subject { Id = 700, Name = " 	لغة عربية  ",   ClassId = 102, TeacherId = 200 },
           new Subject { Id = 800, Name = "  لغة انجليزية  ", ClassId = 102, TeacherId = 500 },
           new Subject { Id = 9, Name = "تربية وطنية وحياتية ", ClassId = 102, TeacherId = 200 },
           new Subject { Id = 10, Name = " تربية إسلامية ",   ClassId = 102, TeacherId = 200 },
           new Subject { Id = 11, Name = " 	حاسوب  ",        ClassId = 102, TeacherId = 200 },
           new Subject { Id = 12, Name = "الرياضيات",        ClassId = 102, TeacherId = 200 },
           // مواد الصف الثالث

           new Subject { Id = 13, Name = " 	لغة عربية  ",      ClassId = 103, TeacherId = 300 },
           new Subject { Id = 14, Name = "  لغة انجليزية  ",   ClassId = 103, TeacherId = 500 },
           new Subject { Id = 15, Name = "تنشئة وطنية واجتماعية ", ClassId = 103, TeacherId = 300 },
           new Subject { Id = 16, Name = " تربية إسلامية ",      ClassId = 103, TeacherId = 300 },
           new Subject { Id = 17, Name = " 	حاسوب  ",           ClassId = 103, TeacherId = 300 },
           new Subject { Id = 18, Name = "الرياضيات",           ClassId = 103, TeacherId = 300 },
           new Subject { Id = 19, Name = " علوم عامة  ",        ClassId = 103, TeacherId = 300 },
           // مواد الصف الرابع

           new Subject { Id = 20, Name = " 	لغة عربية  ",           ClassId = 104, TeacherId = 400 },
           new Subject { Id = 21, Name = "  لغة انجليزية  ",        ClassId = 104, TeacherId = 500 },
           new Subject { Id = 22, Name = "تنشئة وطنية واجتماعية  ", ClassId = 104, TeacherId = 400 },
           new Subject { Id = 23, Name = " تربية إسلامية ",          ClassId = 104, TeacherId = 400 },
           new Subject { Id = 24, Name = " 	حاسوب  ",               ClassId = 104, TeacherId = 400 },
           new Subject { Id = 25, Name = "الرياضيات",               ClassId = 104, TeacherId = 400 },
           new Subject { Id = 26, Name = " علوم عامة  ",            ClassId = 104, TeacherId = 400 },

           // مواد الصف الخامس

           new Subject { Id = 27, Name = " 	لغة عربية  ",         ClassId = 105, TeacherId = 600 },
           new Subject { Id = 28, Name = "  لغة انجليزية  ",      ClassId = 105, TeacherId = 700 },
           new Subject { Id = 29, Name = " دراسات اجتماعية     ", ClassId = 105, TeacherId = 800},
           new Subject { Id = 30, Name = " تربية إسلامية ",        ClassId = 105, TeacherId = 900 },
           new Subject { Id = 31, Name = " 	علوم  ",              ClassId = 105, TeacherId = 1000 },
           new Subject { Id = 32, Name = "الرياضيات",             ClassId = 105, TeacherId = 1000 },
           new Subject { Id = 33, Name = "تكنولوجيا   ",          ClassId = 105, TeacherId = 1000 },


            // مواد الصف السادس

           new Subject { Id = 34, Name = " 	لغة عربية  ",    ClassId = 106, TeacherId = 600 },
           new Subject { Id = 35, Name = "  لغة انجليزية  ", ClassId = 106, TeacherId = 700 },
           new Subject { Id = 36, Name = " دراسات اجتماعية", ClassId = 106, TeacherId = 800 },
           new Subject { Id = 37, Name = " تربية إسلامية ",   ClassId = 106, TeacherId = 900 },
           new Subject { Id = 38, Name = " 	علوم  ",         ClassId = 106, TeacherId = 1000 },
           new Subject { Id = 39, Name = "الرياضيات",        ClassId = 106, TeacherId = 1000 },
           new Subject { Id = 40, Name = "تكنولوجيا   ",     ClassId = 106, TeacherId = 1000 },

            // مواد الصف السابع

           new Subject { Id = 41, Name = " 	لغة عربية  ",    ClassId = 107,    TeacherId = 1100 },
           new Subject { Id = 42, Name = "  لغة انجليزية  ", ClassId = 107, TeacherId = 700 },
           new Subject { Id = 43, Name = " دراسات اجتماعية", ClassId = 107, TeacherId = 800 },
           new Subject { Id = 44, Name = " تربية إسلامية ",   ClassId = 107, TeacherId = 900 },
           new Subject { Id = 45, Name = " 	علوم  ",         ClassId = 107, TeacherId = 1200 },
           new Subject { Id = 46, Name = "الرياضيات",        ClassId = 107, TeacherId = 1200 },
           new Subject { Id = 47, Name = "تكنولوجيا   ",     ClassId = 107, TeacherId = 1200 },


            // مواد الصف الثامن

           new Subject { Id = 48, Name = " 	لغة عربية  ",     ClassId = 108, TeacherId = 1100 },
           new Subject { Id = 49, Name = "  لغة انجليزية  ",  ClassId = 108, TeacherId = 700 },
           new Subject { Id = 50, Name = " دراسات اجتماعية ", ClassId = 108, TeacherId = 800},
           new Subject { Id = 51, Name = " تربية إسلامية ",    ClassId = 108, TeacherId = 900 },
           new Subject { Id = 52, Name = " 	علوم  ",          ClassId = 108, TeacherId = 1200 },
           new Subject { Id = 53, Name = "الرياضيات",         ClassId = 108, TeacherId = 1200 },
           new Subject { Id = 54, Name = "تكنولوجيا",         ClassId = 108, TeacherId = 1200 },


           // مواد الصف التاسع

           new Subject { Id = 55, Name = " 	لغة عربية  ",     ClassId = 109, TeacherId = 1300 },
           new Subject { Id = 56, Name = "  لغة انجليزية  ",  ClassId = 109, TeacherId = 1400 },
           new Subject { Id = 57, Name = " دراسات اجتماعية ", ClassId = 109, TeacherId =  800 },
           new Subject { Id = 58, Name = " تربية إسلامية ",    ClassId = 109, TeacherId = 900  },
           new Subject { Id = 59, Name = " 	علوم  ",          ClassId = 109, TeacherId = 1600 },
           new Subject { Id = 60, Name = "الرياضيات",         ClassId = 109, TeacherId = 1500 },
           new Subject { Id = 61, Name = "تكنولوجيا   ",      ClassId = 109, TeacherId = 1500 },


            // مواد الصف العاشر

           new Subject { Id = 62, Name = " 	لغة عربية  ", ClassId = 110, TeacherId = 1300 },
           new Subject { Id = 63, Name = "  لغة انجليزية  ", ClassId = 110, TeacherId =1400 },
           new Subject { Id = 64, Name = " تاريخ وجغرافيا      ", ClassId = 110, TeacherId =800},
           new Subject { Id = 65, Name = " تربية إسلامية ", ClassId = 110, TeacherId = 900 },
           new Subject { Id = 66, Name = "الفيزياء", ClassId = 110,  TeacherId = 1600 },
           new Subject { Id = 67, Name = "كيمياء", ClassId = 110,    TeacherId = 1600},
           new Subject { Id = 68, Name = "أحياء", ClassId = 110,     TeacherId = 1600 }, 
           new Subject { Id = 69, Name = "الرياضيات", ClassId = 110, TeacherId = 1500 },
           new Subject { Id = 70, Name = "تكنولوجيا   ", ClassId = 110, TeacherId = 1600 },



           // مواد الصف الحادي عشر

           new Subject { Id = 71, Name = " 	لغة عربية  ", ClassId = 111, TeacherId = 1100},
           new Subject { Id = 72, Name = "الرياضيات", ClassId = 111, TeacherId = 1500 },
           new Subject { Id = 73, Name = "  لغة انجليزية  ", ClassId = 111, TeacherId =1400},
           new Subject { Id = 74, Name = " تربية إسلامية ", ClassId = 111, TeacherId = 900 }, 
           new Subject { Id = 75, Name = " تاريخ   ", ClassId = 111, TeacherId = 800 }, 
           new Subject { Id = 76, Name = "جغرافيا", ClassId = 111, TeacherId = 1700 }, 
           new Subject { Id = 77, Name = "ثقافة عامة", ClassId = 111, TeacherId = 1500 }, 
           new Subject { Id = 78, Name = "تكنولوجيا   ", ClassId = 111, TeacherId = 1600 }   );






            builder.Entity<SkillsType>().HasData(
              new SkillsType { Id = 1, Name = " ممتاز" },
              new SkillsType { Id = 2, Name = "جيد جدا " },
              new SkillsType { Id = 3, Name = "   جيد  " },
              new SkillsType { Id = 4, Name = "  مقبول   " }
           );



            builder.Entity<Teacher>().HasData( 
            new Teacher { Id = 100, FirstName = "ألاء",     EmailAddress="" , LastName= "أبو شعير",   PhoneNumber="" }, 
            new Teacher { Id = 200, FirstName = "مها  ",   EmailAddress="" , LastName="ستوم",        PhoneNumber="" }, 
            new Teacher { Id = 300, FirstName = "إيمان ",  EmailAddress="" , LastName= "الجخبير ",   PhoneNumber=""  },
            new Teacher { Id = 400, FirstName = "رندة ",   EmailAddress="" , LastName= "الزيناتي ",  PhoneNumber="" },
            new Teacher { Id = 500, FirstName = "علا",      EmailAddress="" , LastName= "محسن",       PhoneNumber="" },
            new Teacher { Id = 600, FirstName = "إسلام  ",  EmailAddress="" , LastName="البرعي"      ,PhoneNumber="" },
            new Teacher { Id = 700, FirstName = "رانيا",   EmailAddress="" , LastName="حسان",        PhoneNumber=""  },
            new Teacher { Id = 800, FirstName = "اسلام  ",  EmailAddress="" , LastName= "أبو ندى"   ,  PhoneNumber = "" },
            new Teacher { Id = 900, FirstName = " رنا ",   EmailAddress="", LastName = "أبو حمد "   , PhoneNumber = "" }, 
            new Teacher { Id = 1000, FirstName = "وفاء ",  EmailAddress="", LastName = "نصار  "     , PhoneNumber = "" },
            new Teacher { Id = 1100, FirstName = " رشا ",  EmailAddress="", LastName = " الخضري "   , PhoneNumber = "" },
            new Teacher { Id = 1200, FirstName = "نداء ",  EmailAddress="", LastName = "الغولة "   ,  PhoneNumber = "" },
            new Teacher { Id = 1300, FirstName = "هبة  ",  EmailAddress="", LastName = "وشاح"      ,  PhoneNumber = "" },
            new Teacher { Id = 1400, FirstName = "هديل",   EmailAddress="", LastName = "عكاشة "     , PhoneNumber = "" },
            new Teacher { Id = 1500, FirstName = "سحر ",   EmailAddress="", LastName = "لبد",         PhoneNumber = "" },
            new Teacher { Id = 1600, FirstName = "اسلام",   EmailAddress="", LastName = "أبو شمالة" , PhoneNumber = "" },
            new Teacher { Id = 1700, FirstName = "أمل",    EmailAddress = "", LastName = "ياسين "  ,  PhoneNumber = "" });

            //foreach (var item in model.StudentList)
            //{
            //    builder.Entity<ApplicationUser>().HasData(
            //        new ApplicationUser
            //        {
            //        Id =   "8e445865-a24d-4543-a6c6-9443d04" + item.Id,

            //        UserName = item.FullName + "" + item.Id + "@gmail.com",
            //        NormalizedUserName = item.FullName + "" + item.Id + "@gmail.com".ToLower(),

            //        Email = item.FullName + "" + item.Id + "@gmail.com",
            //        NormalizedEmail = item.FullName + "" + item.Id + "@gmail.com".ToLower(),

            //        EmailConfirmed = true,
            //        LockoutEnabled = false,
            //        SecurityStamp = Guid.NewGuid().ToString()
            //     }); 



            //    var password = new PasswordHasher<ApplicationUser>();
            //    var hashed = password.HashPassword(ApplicationUser , "password");
            //    ApplicationUser.PasswordHash = hashed;



            //    //builder.Entity<IdentityUser>().HasData(  new IdentityUser {
            //    //  Id = "8e445865-a24d-4543-a6c6-9443d04"+item.Id, // primary key
            //    //  UserName = item.FullName,
            //    //  Email = item.FullName+""+item.Id+"@gmail.com",
            //    //  NormalizedUserName = item.FullName.ToUpper(),
            //    //    /*PasswordHash = HashPassword(null, "Pa$$w0rd")*/
            //    //});
            //}

            //User user = new User()
            //{
            //    Id = "b74ddd14-6340-4840-95c2-db12554843e5",
            //    UserName = "Admin",
            //    Email = "admin@gmail.com",
            //    LockoutEnabled = false,
            //    PhoneNumber = "1234567890"
            //};

            //PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            //passwordHasher.HashPassword(user, "Admin*123");

            //builder.Entity<User>().HasData(user);
        //}

        //private void SeedRoles(ModelBuilder builder)
        //{
        //    builder.Entity<IdentityRole>().HasData(
        //        new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
        //        new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "HR", ConcurrencyStamp = "2", NormalizedName = "Human Resource" }
        //        );
        //}

        //private void SeedUserRoles(ModelBuilder builder)
        //{
        //    builder.Entity<IdentityUserRole<string>>().HasData(
        //        new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e5" }
        //        );
        //}

    
    }


        
         public DbSet<CompletionType> CompletionType { get; set; }
         public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<StudentApp> StudentApp { get; set; }
         public DbSet<Class> Classes { get; set; }
        public DbSet<Duration> Duration { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<SkillsBehavior> SkillsBehavior { get; set; }
        public DbSet<SkillsType> SkillsType { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Mark> Mark { get; set; }
        public DbSet<Decisions> Decisions { get; set; }
        public DbSet<Semester> Semester { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Subject> Subject { get; set; }
         public DbSet<Teacher> Teacher { get; set; }
         public DbSet<SkillsSuggestions> SkillsSuggestions { get; set; }


        
    }
}
