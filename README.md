# In-MemoriCache
The Power of Caching in ASP.NET Core

Caching is a crucial technique in web development, and ASP.NET Core offers an effective caching mechanism known as Memory Cache. Caching helps improve application performance by reducing the load on external resources, such as databases or APIs, resulting in faster response times and a smoother user experience.

Memory Cache is an in-memory data storage system that allows you to store and retrieve data quickly. It operates as a key-value store, making it versatile for various data types. By storing frequently accessed or computationally expensive data in Memory Cache, you can avoid redundant calculations and database queries, leading to significant performance improvements.

In ASP.NET Core, integrating Memory Cache is straightforward. After adding the Microsoft.Extensions.Caching.Memory package and configuring it in your Startup.cs, you can inject the IMemoryCache interface into your controllers or services. This enables you to utilize Memory Cache for storing and retrieving data efficiently.

Cache options, such as expiration times and cache invalidation, provide fine-grained control over cached data's behavior. For example, you can set a cache duration for specific data, ensuring it remains fresh for a defined period. Cache invalidation allows you to remove cached items when they are no longer valid or needed.

In conclusion, Memory Cache is a valuable tool in ASP.NET Core for optimizing application performance. By strategically caching data, you can reduce response times, lower the load on external resources, and deliver a faster, more responsive web application to your users.




قدرت کش در ASP.NET Core

کش (Caching) یک تکنیک بسیار مهم در توسعه وب است و ASP.NET Core یک مکانیزم کش موثر به نام Memory Cache ارائه می‌دهد. کش به بهبود عملکرد برنامه کمک می‌کند با کاهش بار روی منابع خارجی مانند پایگاه‌های داده یا رابط‌های برنامه‌نویسی (API)، بهبود زمان پاسخ و تجربه کاربری بهتری ارائه دهد.

Memory Cache یک سیستم ذخیره‌سازی داده در حافظه است که به شما این امکان را می‌دهد که داده‌ها را به سرعت ذخیره و بازیابی کنید. این به عنوان یک ذخیره‌سازی کلید-مقدار عمل می‌کند و برای انواع مختلف داده‌ها مناسب است. با ذخیره داده‌های معمولاً دسترسی‌های مکرر یا محاسبات هزینه‌بر در Memory Cache، می‌توانید از محاسبات تکراری و پرس‌وجوهای پایگاه داده جلوگیری کرده و به بهبود قابل توجهی در عملکرد برنامه دست پیدا کنید.

در ASP.NET Core، ادغام کردن Memory Cache بسیار ساده است. پس از افزودن بسته‌ی Microsoft.Extensions.Caching.Memory و تنظیم آن در فایل Startup.cs، می‌توانید رابط IMemoryCache را به کنترلرها یا خدمات‌تان تزریق کنید. این امکان را به شما می‌دهد که از Memory Cache برای ذخیره و بازیابی داده‌ها با کارایی بالا استفاده کنید.

تنظیمات کش مانند زمان انقضاء و نامعتبرسازی کش امکان کنترل دقیق بر رفتار داده‌های کش شده را فراهم می‌کند. به عنوان مثال، می‌توانید مدت زمان کش برای داده‌های خاصی تنظیم کنید تا به مدت مشخصی تازه بمانند. نامعتبرسازی کش اجازه می‌دهد که موارد کش شده را از حافظه‌نهان حذف کنید زمانی که دیگر معتبر یا نیازی به آنها نیست.

به عبارت دیگر، Memory Cache ابزار مهمی در ASP.NET Core برای بهینه‌سازی عملکرد برنامه است. با ذخیره داده‌ها به صورت استراتژیک، می‌توانید زمان پاسخ را کاهش دهید، بار روی منابع خارجی را کاهش دهید و یک برنامه وب سریع‌تر و پاسخگوتر را به کاربران‌تان ارائه دهید.
