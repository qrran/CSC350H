# HW1a Output

<img width="1552" alt="Card Distribution Screenshot" src="https://github.com/qrran/CSC350H/blob/main/HW/HW1/output.png">

## 1. Run the project

```cs
$cd HW
$cd HW1
$dotnet run HW1a.cs
```

### Configuration: .csproj

- ```cs
    <ItemGroup>
      <Reference Include="System" />
      <Reference Include="Cards2"> //name
        <HintPath>HW1/Cards2.dll</HintPath> // relative path of dll under same directory
      </Reference> // add reference
    </ItemGroup>
  ```

```cs
  Card myCard = new Card("Ace", "Hearts");
  Console.WriteLine($"Is the card face up? {myCard.FaceUp}");
   // Output: Is the card face up? False
```

```cs
myCard.FlipOver();
Console.WriteLine($"Is the card face up? {myCard.FaceUp}");
// Output: Is the card face up? True
```

- if an object in the array, use array[index].FaceUp

### Check the type, make sure type is right to use the properties/method
