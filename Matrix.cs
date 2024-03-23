using System;
using System.Collections.Generic;



// This Ma
public class Matrix 
{

   

  public Matrix(List<Box> currentBoxes)
  {
     boxes = currentBoxes;

  } 

  public Matrix(int R , int C)
  {
       NumberOfCols = C;
       NumberRows = R;
     

  }
   


   public int NumberRows {get;set;}
   public int NumberOfCols {get;set;} 


   public List<Box>? boxes {get;set;}
   
    public List<Box>? SkipBoxes {get;set;}
    
    public bool RotateMatrix {get;set;}

// C++ program to rotate a matrix


// A function to rotate a matrix mat[][] of size R x C.
// Initially, m = R and n = C

// Matrix Transaction based Box based Storage rotating each time so hacker cant get there
// No SQL Server just a new Data Grid with MAtrix behind strong firewall
// the hacker will hit his head on the wall and won't get the transaction details
// Rotating Data millions of time per seconds






public List<ImageClass> rotateMatrixBox(int m ,int n , ImageClass[][] classes)
{
    // Not imeplmented ...


    




    return new List<ImageClass>();
       

}






public List<Box> rotateMatrixBox(int m ,int n , List<Box> boxes)
{



    return new List<Box>();

}

public int[][] rotatematrix(int m, int n, int[][] mat )
{
    int row = 0, col = 0;
    int R = NumberRows ;
    int C = NumberOfCols;
    int prev, curr;

    

    /*
    row - Starting row index
    m - ending row index
    col - starting column index
    n - ending column index
    i - iterator
    */
    while (row < m && col < n)
    {

        if (row + 1 == m || col + 1 == n)
            break;

        // Store the first element of next row, this
        // element will replace first element of current
        // row
        prev = mat[row + 1][col];

        /* Move elements of first row from the remaining rows */
        for (int i = col; i < n; i++)
        {
            curr = mat[row][i];
            mat[row][i] = prev;
            prev = curr;
        }
        row++;

        /* Move elements of last column from the remaining columns */
        for (int i = row; i < m; i++)
        {
            curr = mat[i][n-1];
            mat[i][n-1] = prev;
            prev = curr;
        }
        n--;

        /* Move elements of last row from the remaining rows */
        if (row < m)
        {
            for (int i = n-1; i >= col; i--)
            {
                curr = mat[m-1][i];
                mat[m-1][i] = prev;
                prev = curr;
            }
        }
        m--;

        /* Move elements of first column from the remaining rows */
        if (col < n)
        {
            for (int i = m-1; i >= row; i--)
            {
                curr = mat[i][col];
                mat[i][col] = prev;
                prev = curr;
            }
        }
        col++;
    }

    // Print rotated matrix
    
    
      Console.WriteLine($"Current Rotation found as == {mat[m][n]}" );
      return mat;
    


/* Driver program to test above functions */




    



}

}