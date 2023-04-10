//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace INTEX2.Models
//{
//    //This class will implement an instance of our interface (IWaterProjectRepository)
//    public class EFMummyRepository : IMummyRepository
//    {
//        // These next two lines are very similar to what was in our home controller.  This connects us to the dbContext file
//        //Does what we used to do in or controller.
//        private MummyContext context { get; set; }
//        public EFMummyRepository(MummyContext temp)
//        {
//            context = temp;
//        }
//        public IQueryable<Mummy> Mummies => context.Mummies;
//    }
//}