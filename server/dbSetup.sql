CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

-- This creates our table

CREATE TABLE
    IF NOT EXISTS burgers(
        id INT NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'This is the Id of the burger.',
        name CHAR(255) NOT NULL,
        breadType ENUM ('wheat', 'white', 'sourdough') NOT NULL,
        hasCheese BOOLEAN NOT NULL DEFAULT true
    ) default charset utf8 COMMENT '';

-- This adds data to our table

INSERT INTO
    burgers (name, breadType, hasCheese)
VALUES (
        'patty melt',
        'sourdough',
        true
    );

-- This basically grabs specific info out of our table

SELECT name FROM burgers;

-- This deletes the entire table

DROP TABLE burgers;

-- END OF BURGER SECTION