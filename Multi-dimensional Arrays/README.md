# Multidimensional Arrays in OOP (C#)

## Definition

A **multidimensional array** is an array that contains **more than one dimension**. In **Object-Oriented Programming**, it is commonly used to store data in **row and column (table) form**.

---

## Why Multidimensional Arrays are Used

* To represent tables or matrices
* To store structured data
* To manage data in rows and columns
* To solve real-world problems efficiently

---

## Key Terms

* **Row**: Horizontal data
* **Column**: Vertical data
* **Index**: Position of an element
* **Dimension**: Number of levels in an array

---

## Types of Multidimensional Arrays

* **2D Array** (Rows × Columns)
* **3D Array** (Layers × Rows × Columns)

---

## Syntax (2D Array in C#)

```csharp
int[,] numbers = new int[2, 3];
```

---

## Example

```csharp
int[,] matrix = {
    {1, 2, 3},
    {4, 5, 6}
};

Console.WriteLine(matrix[0, 1]); // Output: 2
```

---

## Using Loops with Multidimensional Arrays

```csharp
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
```

---

## Multidimensional Arrays in a Class

```csharp
class Data
{
    public int[,] values = {
        {10, 20},
        {30, 40}
    };
}
```

---

## Important Points

* Index starts from 0
* Size is fixed
* Loops are usually nested

---

## Conclusion

Multidimensional arrays are an important OOP concept used to store and process data in structured form such as tables and matrices.
