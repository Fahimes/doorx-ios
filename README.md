# DoorX .NET MAUI

این پروژه بازسازی اولیه DoorX بر اساس پروژه Android `SmartDoor2` است.

## وضعیت
- هدف‌ها: Android / iOS / MacCatalyst / Windows
- API پایه ESP: `http://192.168.4.1`
- بدون Firebase/Supabase/Backend جدید
- Session در SecureStorage نگهداری می‌شود.
- iOS Local Network permission و HTTP محلی تنظیم شده است.

## مرحله بعد
روی Windows در Visual Studio پروژه را باز کن و ابتدا Build اندروید را تست کن. سپس UI و APIها را با سخت‌افزار واقعی DoorX تست می‌کنیم و بعد سراغ build iOS می‌رویم.

> برای build واقعی iOS در نهایت محیط macOS/Xcode و signing اپل لازم است؛ این پروژه قسمت کدنویسی و پیکربندی iOS را آماده می‌کند.
