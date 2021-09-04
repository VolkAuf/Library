# Здравствуйте, это краткое руководство по проекту

### Запуск:
1. Открываем проект в Visual studio.
1. Кликаем пкм по Решению:<br/>
![Решение](https://sun9-33.userapi.com/impg/lpXxD4cQV-IwcX-9T9v6NnDx2MqOKo6PskzRxw/hJohMOeLcPM.jpg?size=327x138&quality=96&sign=03981edf902c8102f1c1f9f59c276505&type=album)
1. В выподающем меню выбираем "Свойства".<br/>
![Свойства](https://sun9-60.userapi.com/impg/HSZh3TotDqKTUjjSn722MiHaA1cQ1LAgCpQ3jA/wx2ARVSD42E.jpg?size=522x740&quality=96&sign=6efcfd3140757f6d9f7c521592652a85&type=album)
1. В открывшемся меню мы видим способ запуска приложения.<br/>
![МенюЗапуска](https://sun9-83.userapi.com/impg/qm5EiFxAIw-dud574q4kX-mm5swnuVnWbOEH1w/0OGTtB8tg5s.jpg?size=979x680&quality=96&sign=f8e87208d90b7c2faf64789c5707ebe6&type=album)
1. Выбираем "Несколько запускаемых проектов", где выбираем Library и Library.Auth.<br/>
![МенюЗапуска2](https://sun9-6.userapi.com/impg/iJ7_DLe8HRaALbySpU7bP3yWU1aoMup-ZMwoUA/ANQvlOfRvWU.jpg?size=734x481&quality=96&sign=88d97af54bc26f328bfba63a89b2303c&type=album)
1. Далее жмём на кнопку пуск и восхищаемся.<br/>
![КнопкаПуск](https://sun9-19.userapi.com/impg/L-Y4ZredSvAh_haDyPeE0ILhRTqkUTW8b3pN0Q/65g682w9i7I.jpg?size=345x131&quality=96&sign=f6663279acd5d2d1a2b88c63175dc82b&type=album)

---

### Проверка работоспособности:

1. Открываем Postman и выполняем проверку получения всех книг.<br/>
![Книги](https://sun9-67.userapi.com/impg/oEj6TvMUMYtgP7CsrzyGDOD1xfl8DZu5oODVhg/A-UrtBLxhoM.jpg?size=1870x917&quality=96&sign=7178546f826daa0aaa75bd9efffe449d&type=album)
1. Проверка получения фильтрованного по жанру списка книг.<br/>
![Книги с фильтром](https://sun9-20.userapi.com/impg/bLKfowwtchKe9OTG-Zm4c6pVNkV3KoialUEqOQ/3R5qz7_2lkU.jpg?size=1870x914&quality=96&sign=c9616264c00f3b70bc1ae9a90e8f8f97&type=album)
1. Получение списка книг пользователя, без авторизации.<br/>
![Unauthotized](https://sun9-56.userapi.com/impg/NPhOruyxBX7W-Lcl2gX1zQ2VUgVXGZEE9GS9zw/GgPc-w-ROHE.jpg?size=1393x833&quality=96&sign=29f040e8259b4818f19bd9f9ce7fc8fd&type=album)
1. Проверка авторизации и получение токена.<br/>
![Авторизация](https://sun9-82.userapi.com/impg/2hP_QK1YScRz6EdgSagEj0CYD7BHscoLsUQ-9w/SkhBmggqf8s.jpg?size=1869x911&quality=96&sign=063ea371b53c5429c663419270551a7d&type=album)
1. Получение спика книг авторизованного пользователя.<br/>
![Авторизован](https://sun9-8.userapi.com/impg/ohiV8N0lN-VDfYB5tHwYlISNguMtULOaOKZ0WA/FCfRjDzMTr8.jpg?size=1871x914&quality=96&sign=3679467ced68e21f78418f4e1c1a679d&type=album)
1. Проверка токена на JWT.io:
- Копируем полученный ранее токен.<br/>
![Токен](https://sun9-47.userapi.com/impg/LU-0ODk6JNnR-EL0CzJ13w7oubjJMm0fOrGDAQ/zROyOpQ3QRg.jpg?size=1869x911&quality=96&sign=3e5e3ff402da0288bc9cee6af0ae546e&type=album)
- Переходим на сайт.<br/>
![Сайт](https://sun9-88.userapi.com/impg/tDAqSKUa-fvfGSNa3LanvKOVUyy-963M3noQ9A/o8K1lvc8oaw.jpg?size=1868x919&quality=96&sign=60039efe9f73fcde26dec26f3fd2f803&type=album)
- Вставляем токен в левое окошко.<br/>
![ВставкаТокена](https://sun9-45.userapi.com/impg/RCnLVtpwdnoMwGGWEbnJtACmbSH5srRMx7gjlQ/eUhcelM3SfU.jpg?size=1473x791&quality=96&sign=7475eac15b125de7e72c56fe7f1123f2&type=album)
- Переходим в Visual studio и открываем файл appsettings.json.<br/>
![VSApp](https://sun9-37.userapi.com/impg/cFCXwJ5Id29VbduNCx3lpQRT7k1Bzrg94pThyQ/V17w0OH7PuQ.jpg?size=323x375&quality=96&sign=8b60c8af3aade419d3848f0d7f7fbd00&type=album)
- Копируем секретный ключ(very_complex_encryption_key).<br/>
![Ключ](https://sun9-55.userapi.com/impg/Ai_xcccVCZ2A_HRfVbwFU2EkKJpO-uiHGK_NiA/ScJuasi9Zb8.jpg?size=519x413&quality=96&sign=a509dbf7604ae754550c068a1698a30c&type=album)
- Вставляем и проверяем верификацию.<br/>
![Верификация](https://sun9-53.userapi.com/impg/P74ANyQ1AmyFNP3In5TGRSTBt7QuixS_nhLMmg/B-kGZ0T95R4.jpg?size=1475x744&quality=96&sign=6daac62302d5f055b25b293b173e98b5&type=album)
---

### База данных
- Созданная база данных.<br/>
![БД](https://sun9-6.userapi.com/impg/8wjfHB3BTa4w6vq8gMRwARzUrhPwNTqkBM2hMQ/rAWkUEcc0Fo.jpg?size=315x115&quality=96&sign=3d8c226f1406eb03a4c41bbbe6a830b7&type=album)
- Коллекция Книг.<br/> 
![Книги](https://sun9-88.userapi.com/impg/xXXLzvUbIy28SRIBr3fu7nBj9XbCFyWHBSvV6g/pF5xDwj3Ikk.jpg?size=1267x924&quality=96&sign=d32a1df2cba9e37ebd6429d71404b415&type=album)
- Коллекция Клиентов.<br/>
![Клиенты](https://sun9-65.userapi.com/impg/G1xxk8npTs9OpBotM0RKWchYcbo2E66doirqqQ/YoGiMpF-eaA.jpg?size=1268x504&quality=96&sign=74384d37444f1ac1bdc99925167f6b94&type=album)
