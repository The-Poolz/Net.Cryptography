using Xunit;
using FluentAssertions;

namespace Net.Cryptography.SHA256.Tests
{
    public class SHA256Tests
    {
        [Fact]
        internal void ToSha256_WithEmptyString_ReturnsCorrectHash()
        {
            const string input = "";
            const string expected = "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855";

            var result = input.ToSha256();

            expected.Should().Be(result);
        }

        [Fact]
        internal void ToSha256_WithNonEmptyString_ReturnsCorrectHash()
        {
            const string input = "Hello World";
            const string expected = "a591a6d40bf420404a011733cfb7b190d62c65bf0bcda32b57b277d9ad9f146e";

            var result = input.ToSha256();

            expected.Should().Be(result);
        }

        [Fact]
        internal void ToSha256_WithDifferentStrings_ReturnsDifferentHashes()
        {
            const string input1 = "Hello World";
            const string input2 = "hello world";

            var result1 = input1.ToSha256();
            var result2 = input2.ToSha256();

            result1.Should().NotBe(result2);
        }
    }
}