public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        // Başlangç değeri için int türünde bir değişken oluşturuyruz.
        int a = 0;
        
        // nums dizisinin tüm elemanlarını dönüceğimiz bir döngü oluşturucaz.
        foreach(int i in nums)
        {
            // Sıradaki elemanın val'a eşit olmadığı durumda;
            if (i != val)
            {
                // nums'ın a indexindeki değeri sıradaki değer ile değiştiriyoruz.
                nums[a] = i;
                
                // a değerini 1 arttırıyoruz. Bu sayede nums'da sıradaki index'e geçmiş oluyoruz.
                a++;
            }
        }
        
        return a;
    }
}