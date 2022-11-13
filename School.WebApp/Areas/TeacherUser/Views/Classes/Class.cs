

//< div class= "row" style = "margin-top:-4.5rem !important; margin-bottom:2rem; " >
  
//      < div class= "col-12 text-right" style = "margin-bottom: 50px;padding: 30px;
//              background - color: #fff;box-shadow: rgb(0 0 0 / 10%) 0px 5px 12px;">
//        < div style = "color: #1459AE; font-weight: 700; font-size: 18px; margin-bottom: 35px; " >
 
//             < span >
 
//                 .مرحبا بك , في صفحة تفاصيل وبيانات الفصل الدراسي
//            </span>
//        </div>
//        <div class= "badge-title" style = "" >
 
//             < span class= "small-info " >
  
//                  .هذه الصفحة تعرض جميع طلاب الفصل والبيانات الخاصة بهم بشكل مفصل وواضح
//            </span>
//        </div>
//    </div>
//</div>
//<div class= "row" style = "margin-right: -30px; margin-left: -52px;" >
 
//     < div class= "col-md-12" >
  


//          < div class= "col-md-12 text-right" >
//               @if(Model.Decisions.AllowToCreatMarks == true)
//            {
//    @if(Model.Decisions.CreatedAllowedFrom <= DateTime.Now || Model.Decisions.CreatedAllowedTo >= DateTime.Now)
//                {


//                    < a asp - action = "Create" asp - controller = "Marks" asp - route - id = "@Model.ClassID" class= "btn btn-default" style = "background-color: #4159AE; border-color: #221ecd; color: #fff; " >
//                                        إضافة درجة جديدة
//                                        <i class= "fa-solid fa-plus" ></ i >
                
//                                    </ a >


//                }
//                else
//{
//                    < button disabled class= "btn btn-default" style = "background-color: #4159AE; border-color: #221ecd; color: #fff; " >
//                          إضافة درجة جديدة
//                          <i class= "fa-solid fa-plus" ></ i >
  
//                      </ button >
//                }
//            }
//            else
//{
//                < button disabled class= "btn btn-default" style = "background-color: #4159AE; border-color: #221ecd; color: #fff; " >
//                      إضافة درجة جديدة
//                      <i class= "fa-solid fa-plus" ></ i >
  
//                  </ button >
//            }
//            < br />
//            < br />
//            < br />
//        </ div >




//        < table id = "myTable" class= "table dt-responsive table-hover" style = "width: 102%; margin-left: 0px;" >
    
//                < thead class= "thead_dark" >
     
//                     < tr style = " background-color: #8c9cd0; border: 0px; color: #fff;" >
      
//                          < td class= "text-right" style = " border-top-left-radius: 16px; border-bottom: 0px;" > الإجراءات </ td >
        
//                            < td class= "text-center mobile-hidden" > الدرجة النهائية </ td >
           
//                               < td class= "text-center mobile-hidden" > درجات التقويم النوعي</td>
//                                 <td class= "text-center mobile-hidden" > الإختبارات القصيرة </ td >
              
//                                  < td class= "text-right mobile-hidden" > مدرس المادة </ td >
            
//                                < td class= "text-right mobile-hidden" > المادة </ td >
             
//                                 < td class= "text-right" style = " border-top-right-radius: 16px; border-bottom: 0px;" > اسم الطالب </ td >
               

//                               </ tr >
               
//                           </ thead >
               

//                           < tbody >
//                               @foreach(var item in Model.MarkList)
//                {
//                    < tr style = "  color: #000;" >
 
//                         < td class= "text-right" >
  
//                              < div class= "dropdown" >
   
//                                   < button class= "btn btn-secondary"
//                                        type = "button"
//                                        id = "dropdownMenuButton"
//                                        data - toggle = "dropdown"
//                                        aria - haspopup = "true"
//                                        aria - expanded = "false" style = "background-color: #fff;border:0px;" >
    
//                                        < i class= "fa-solid fa-ellipsis" style = "color: #000;" ></ i >
      
//                                      </ button >
      

//                                      < div class= "dropdown-menu text-right"
//                                     aria - labelledby = "dropdownMenuButton" style = "" >
    
//                                        < a class= "dropdown-item" asp - action = "GetStudentMarks" asp - controller = "Marks" asp - route - id = "@item.StudentId" >
//                                                      التفاصيل
//                                                      < i class= "fa-sharp fa-solid fa-eye" style = "padding-left: 5px;" ></ i >
                
//                                                    </ a >
//                                    @*< a class= "dropdown-item" asp - action = "Delete" asp - controller = "Marks" asp - route - id = "@item.StudentId" >
//                                                  حذف
//                                                  < i class= "fa-solid fa-trash" style = "padding-left: 5px;" ></ i >
            
//                                                </ a > *@
//                                </ div >
//                            </ div >

//                        </ td >


//                        < td class= "text-center mobile-hidden" > @Html.DisplayFor(modelItem => item.FinalTermValue) </ td >
 
//                         < td class= "text-center mobile-hidden" > @Html.DisplayFor(modelItem => item.QualitativeAssessmentGrades) </ td >
  
//                          < td class= "text-center mobile-hidden" > @Html.DisplayFor(modelItem => item.ShortQuizzes) </ td >
   

//                           < td class= "text-right mobile-hidden" > @Html.DisplayFor(modelItem => item.Teacher.FullName) </ td >
    
//                            < td class= "text-right mobile-hidden" > @Html.DisplayFor(modelItem => item.Subject.Name) </ td >
     
//                             < td class= "text-right" > @Html.DisplayFor(modelItem => item.Student.FullName) </ td >
      

//                          </ tr >
//                }
//            </ tbody >
//        </ table >
//    </ div >
//</ div >


