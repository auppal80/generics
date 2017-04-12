# generics
Generics Examples
take a look at Operation.cs. Class inside this is an example of generics.
   public class Generics1<Tdata,Tdata1, result1> --That means when we instantiate Generics1 Class we can say what kinf of input parameters 
  we will have. Example we can say Operation<int, int, int> operationInt = new Operation<int, int, int>(); Which means Tdata1 is of type int,
  Tdata2 is of type int and result1 is of type int as well.
  The whole idea of generics is that at run time we can do operation based on types passed
  
