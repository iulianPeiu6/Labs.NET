# Labs.NET

## Lab1

Project Requirements: [Lab no. 1. Project Requirements](https://docs.google.com/document/d/1yvDcGLEIEMuLAceOTZ-n00U9XvVxnUiN/edit)  
Possible explanations are provided as comments in the project source code.

## Lab2  

Project Requirements: [Lab no. 2. Project Requirements](http://codekata.com/kata/kata04-data-munging/)  

### Kata Answers  

Wring the functionalities for Weather Data & Soccer League Table was done independently by different team members. So there was an influence on how the second person wrote the code, having as a model the first one. The starting idea was surprisingly good and make it easy to factor out common code by identifying common components between Weather Data & Soccer League Table.  

Initial approach (bad code):  
- Duplicated code, Redundancy - Hard to maintain  
  At first, we did not apply the Law of Demeter as we should: Read & Process Records were in the same class. So we refactor it to have two classes that handle Read, respectively Process independently. Having duplicated code in the first version, refactoring was two times time-consuming due to changes in both Weather Data & Soccer League Table.
- Easier to write code in this way , but not smarter  
- Takes more time to read due to duplications. Haha  

The Second approach (good code):  
- Sometimes requires a high time investment and additional knowledge (e.g. in our case reflection, generic programming)  
- Sometimes is harder to read and understand due to generalization  
- The coupling level grows  
- Easier to maintain - change only the common code and not every instance of that code where it appears  
