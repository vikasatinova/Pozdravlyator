# Pozdravlyator
Приложение "Поздравлятор". Функциональность приложения - ведение списка дней  рождения (далее ДР) друзей/знакомых/сотрудников.
 а именно: <br>
• Отображение всего списка ДР (дополнительные возможности, такие как сортировка, 
выделение текущих и просроченных и т.п. - остаются на усмотрение реализующего)  <br>
• Отображение списка сегодняшних и ближайших ДР (дополнительные возможности, 
такие как сортировка, выделение текущих и просроченных и т.п. - остаются на усмотрение 
реализующего)  <br>
• Добавление записей в список ДР <br>
• Удаление записей из списка ДР <br>
• Редактирование записей в списке ДР <br>

Серверное веб-приложение (ASP.NET Core MVC), информация хранится в объектах, 
персистентность которых реализуется с помощью использования БД. Корневая страница выводит 
список сегодняшних и ближайших ДР, остальная функциональность доступна на отдельных 
страницах, ссылки на которые ведут с корневой. Реализовано хранение и 
отображение фотографий именинников.