public class Codec {
    private Dictionary<string, string> dict = new Dictionary<string, string>();
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        using(var md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider()){
            var urlBytes = System.Text.Encoding.ASCII.GetBytes(longUrl);
            var md5Bytes = md5Hasher.ComputeHash(urlBytes);
            var base64 = Convert.ToBase64String(md5Bytes);
            var shortUrl = base64.Substring(0, 7);
            dict[shortUrl] = shortUrl;
            return shortUrl;
        }
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        return dict[shortUrl];
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));