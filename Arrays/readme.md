# Arrays in OOP (C#)

## Definition

An **array** is a data structure that stores multiple values of the **same data type** in a single variable. In **Object-Oriented Programming**, arrays are commonly used inside classes to manage related data.

---

## Why Arrays are Used

* To store multiple values in one variable
* To manage data efficiently
* To work easily with loops
* To organize object-related data

---

## Key Terms

* **Array**: Collection of same-type elements
* **Index**: Position of an element (starts from 0)
* **Length**: Total number of elements

---

## Syntax (C#)

```csharp
int[] numbers = new int[5];
```

---

## Example

```csharp
int[] marks = { 85, 90, 78 };
Console.WriteLine(marks[0]); // Output: 85
```

---

## Arrays in a Class

```csharp
class Student
{
    public int[] marks = { 80, 85, 90 };
}
```

---

## Important Points

* Arrays have fixed size
* Index starts from 0
* All elements must be of same data type

---

## Conclusion

Arrays are a basic and important concept in OOP used to store and manage multiple values efficiently.

