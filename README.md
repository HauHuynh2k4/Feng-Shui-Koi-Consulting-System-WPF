# Koi Feng Shui Consulting System

A consulting system that helps users choose the most suitable Koi fish based on Feng Shui principles, birth year, and gender.

## Description

Koi Feng Shui Consulting System is a WPF (Windows Presentation Foundation) application that provides:

- Koi fish consultation based on user's birth year and gender
- Feng Shui compatibility calculation between users and their Koi fish
- Pond design recommendations based on Feng Shui elements
- Administrative tools for managing users, ponds, and Koi fish data

## Key Features

1. **Feng Shui Consultation**

   - Birth year analysis
   - Gender compatibility
   - Element matching
   - Koi fish recommendations

2. **Compatibility Calculator**

   - User-Koi compatibility score
   - Pond-Koi harmony analysis
   - Feng Shui element balance

3. **Admin Management**
   - User CRUD operations
   - Koi fish database management
   - Pond design catalog
   - System configuration

## Technologies Used

- .NET 6.0
- WPF (Windows Presentation Foundation)
- Entity Framework Core
- SQL Server
- MVVM Architecture

## Project Structure

KoiFengShui.BE/
├── FengShuiKoi_BO/ # Business Objects
├── FengShuiKoi_DAO/ # Data Access Objects
├── FengShuiKoi_Repository/ # Repositories
├── FengShuiKoi_Services/ # Business Services
└── KoiFengShuiSystem/ # WPF Application

## Installation

1. Clone repository:

git clone https://github.com/HauHuynh2k4/Feng-Shui-Koi-Consulting-System-WPF.git

2. Update database:

dotnet ef database update

3. Run application:
