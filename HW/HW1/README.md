## 1. .csproj

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
  Console.WriteLine($"Is the card face up? {myCard.IsFaceUp}");
   // Output: Is the card face up? False
```

```cs
myCard.FlipOver();
Console.WriteLine($"Is the card face up? {myCard.IsFaceUp}");
// Output: Is the card face up? True
```

### Check the type, make sure type is right to use the properties/method
