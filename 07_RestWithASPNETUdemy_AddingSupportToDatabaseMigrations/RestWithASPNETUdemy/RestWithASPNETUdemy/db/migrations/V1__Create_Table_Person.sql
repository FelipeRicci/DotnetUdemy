CREATE TABLE if NOT EXISTS `person` (
	`first_name` VARCHAR(80) NOT NULL,
	`last_name` VARCHAR(80) NOT NULL,
	`id` BIGINT(20) NOT NULL AUTO_INCREMENT,
	`address` VARCHAR(100) NOT NULL,
	`gender` VARCHAR(6) NOT NULL,
	PRIMARY KEY(`id`)
);