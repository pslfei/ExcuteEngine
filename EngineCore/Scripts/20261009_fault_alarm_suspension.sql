-- 在应用程序启动前，由部署人员在目标 MySQL 数据库执行。
-- MySQL 5.7 兼容；已有字段时不会重复添加，也不会覆盖已有挂起状态。
SET @fault_suspension_ddl = IF(
    EXISTS (
        SELECT 1 FROM information_schema.COLUMNS
        WHERE TABLE_SCHEMA = DATABASE()
          AND TABLE_NAME = 'troubleshooting'
          AND COLUMN_NAME = 'IsAlarmSuspended'
    ),
    'SELECT ''IsAlarmSuspended already exists'' AS result',
    'ALTER TABLE `troubleshooting` ADD COLUMN `IsAlarmSuspended` INT NULL DEFAULT 0'
);
PREPARE fault_suspension_stmt FROM @fault_suspension_ddl;
EXECUTE fault_suspension_stmt;
DEALLOCATE PREPARE fault_suspension_stmt;
