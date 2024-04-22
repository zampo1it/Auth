Задание №4 (ВСЕ НАПРАВЛЕНИЯ)

Реализуйте Web-приложение, позволяющее пользователям зарегистрироваться и аутентифицироваться. Неаутентифицированные пользователи не имеют доступа к управлению пользователями (доступ только к форме регистрации или форме аутентификации).
Только аутентифицированные пользователи видят таблицу "пользователи" (идентификатор, именем, мылом, датой регистрации, датой последнего логина, статусом) с пользователями.

Таблица в самой левой колонке содержит чек-боксы для множественного выделения, в заголовке колонки только чек-бокс без текста, позволяющи выделить или снять выделение со всех записей. 

Над таблицей должен быть тулбар с действиями: Block, Unblock, Delete (два последних можно и лучше иконками). Таблица, множественное выделение, тулбар — обязательно. 

Обязательно использование CSS-фреймворка (рекомендация — Bootstrap, но можно любой другой).

Каждый пользователь может удалить или заблокировать себя или другого пользователя.

Если кто-то другой блокирует или удаляет пользователя, то при любом следующем запросе пользователь переправляется на страницу логина.

При регистрации должна быть возможность использовать любой пароль, даже из одного символа. Если вы используете готовый сервис для хранения пользователей, вы можете 1) реализовать своих "пользователей" или 2) принять, что некоторые требования не могут быть реализованы (зато получить результаты быстрее).

Заблокированный пользователь не может войти, удаленный может заново зарегистрироваться.
