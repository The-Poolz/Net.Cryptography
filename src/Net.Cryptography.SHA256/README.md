# Net.Cryptography.SHA256

`Net.Cryptography.SHA256` is a simple and efficient SHA256 hashing library for .NET applications.
It extends the string class to provide easy-to-use SHA256 hash generation functionality.

## Features

- **Easy-to-use**: Extend the string class for intuitive SHA256 hash generation.
- **Efficient**: Optimized for performance in .NET 6.0 environments.
- **Secure**: Ideal for cryptographic operations and data integrity checks.

## Usage

Using Net.Cryptography.SHA256 is straightforward:

```csharp
using Net.Cryptography.SHA256;

string myString = "Hello World";
string hash = myString.ToSha256();
Console.WriteLine(hash);
	// Outputs SHA256 hash of "Hello World"
	// a591a6d40bf420404a011733cfb7b190d62c65bf0bcda32b57b277d9ad9f146e
```