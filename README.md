# MIKOLAJCZAK_ANTOINE_TP6_ST2TRD

Exercise 1 

1)	A clean code is a code which is easily understandable even and specially for a programmer who discover the code
It’s a goal for every programmer to produce a code like that. A clean code have some property which make him great :

-	No duplication 
-	Minimum number of class 
-	A tested code which is working 

2)	Yes for me it’s possible to refactor some code because the perfect code doesn’t exist and it’s possible to improve it. 
Especially when many programmer are working on the same code because they don’t have the same way of thinking. Due to this they can give a new look on certain parts of code in order to refactor it. 

3)	Things we call code smell are some properties or indicators which show that the code is not clean. When a code smells, either the writing is verry awful of sometimes, there are big problems underlying. 

4)	In the original guilded rose there is some code smells indicators. there is too much “if” statement and due to this, it is really complicate to read and to understand even for the guy who write the code, I think. Moreover, for me it could have been split in some many classes in order to have a clean code.

5)	Guilded rose original code could be improve with some technic. First, I think the class “Item.cs” should be improved by adding some attribute to Items objects in order to have a better management in the future. Then, classes are not well designed to my mind, it perhaps be smarter to split existing classes into other classes underlying in order to have a better design / architecture of the code. 


Ecercise 2 

1 - In simple terms, and a few sentences at most, what’s a design pattern?

A design pattern is a specific concept which is used to resolve some often-occurring problems. It’s a way to solve them, it is not a magic piece of code which solve everything. 
It’s important to chose the design pattern which is appropriate to the problem. Chosing a random pattern will not solve the problem.

a.When should you use one?
You can use a design pattern when you are in front of a problem which is known and recurrent. This kind of pattern are used to give a director line to the programmer. But he never should have to follow it blindely.

2) you can find the pizza builder pattern with the files Builder.cs Pizza.cs Program.cs  

3) we are searching to implement a decorator pattern. We could imagine a situation where we have a car and we wanted to add some things on it like light, dice hanging on mirrors, covering …
As I understood the decorator pattern, it should have some problems with the implementation of the situation above. We declare all decorations objects inside the code but it seems complicate to choose especially decorations we want on the cars like in the builder pattern.  

4) I choose the factory method design pattern with an iphone situation 
all code are in the Assemblage.cs and Iphone.cs with program.cs 
