# MarsRover

Problem Tanımı 

  NASA, Mars'taki bir platoya robotik gezicilerden oluşan bir ekip indirecek. Garip bir şekilde 
dikdörtgen olan bu plato, geziciler tarafından gezinilmeli, böylece araç kameraları, Dünya'ya 
göndermek için çevredeki arazinin tam bir görüntüsünü alabilir. 

  Bir gezicinin konumu, x ve y koordinatlarının bir kombinasyonu ve dört ana pusula noktasından 
birini temsil eden bir harf ile temsil edilir. Plato, navigasyonu basitleştirmek için bir ızgaraya 
bölünmüştür. 

  Örnek bir konum 0, 0, N olabilir; 
  
  Bu, gezicinin sol alt köşede ve kuzeye dönük olduğu anlamına gelir. Bir geziciyi kontrol etmek 
için NASA basit bir harf dizisi gönderir. Olası harfler 'L', 'R' ve 'M'dir.

  'L' ve 'R', gezicinin mevcut noktasından hareket etmeden sırasıyla 90 derece sola veya sağa 
dönmesini sağlar. 

  'M', bir ızgara noktası ileri gitmek ve aynı istikameti korumak anlamına gelir. (x, y) noktasından 
doğrudan kuzeydeki karenin (x, y+1) olduğunu varsayın. 

  İlk girdi satırı platonun sağ üst koordinatlarıdır, sol alt koordinatların 0,0 olduğu varsayılır. 
Girdinin geri kalanı, konuşlandırılan gezicilere ilişkin bilgilerdir. Her gezicinin iki giriş satırı vardır. İlk 
satır, gezicinin konumunu verir ve ikinci satır, geziciye platoyu nasıl keşfedeceğini söyleyen bir dizi 
talimattır. 

  Konum, x ve y koordinatlarına ve gezicinin yönüne karşılık gelen iki tam sayıdan ve boşluklarla 
ayrılmış bir harften oluşur. Her gezici sırayla tamamlanacak, bu da ikinci gezicinin birincisi hareket 
etmeyi bitirene kadar hareket etmeye başlamayacağı anlamına geliyor. Çıktı: Her gezici için çıktı, nihai 
koordinatları ve yönü olmalıdır. 

## **Veri Girişi**----------------------------- **Çıktı**  

5 5                                         

1 2 N

LMLMLMLMM-------------------------------------------1 3 N

3 3 E

MMRMMRMRRM----------------------------------------5 1 E
