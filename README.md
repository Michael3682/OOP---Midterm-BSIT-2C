# 🏨 BSIT 2C - Hotel Reservation System

A simple console-based Hotel Reservation System built using **C#** and **Object-Oriented Programming** principles like inheritance, encapsulation, and polymorphism. It allows users to select a room type, input their name and length of stay, and calculates the total cost based on room type.

---

## 📁 Project Structure

- **Program.cs** – Entry point of the application; handles user input and displays reservation info.
- **Reservation.cs** – Abstract base class for all reservation types.
- **RoomTypes.cs** – Contains derived room reservation classes (`StandardRoomReservation`, `SuiteRoomReservation`, etc.).

---

## 🛠️ How to Run

1. **Clone or download** the project.
2. Open the project folder in **Visual Studio** or any C# IDE.
3. Build the solution to restore dependencies and compile the project.
4. Run the program (usually by pressing `Ctrl + F5` or clicking the **Start** button).

---

## 🧪 How to Test

1. Upon running, the console will prompt for:
   - Your name
   - Room type (Standard, Suite, Deluxe, or Luxury)
   - Number of nights

2. The system will calculate and display:
   - Reservation details
   - Total cost of stay

3. It will ask if you'd like to make another reservation.

4. Type **"no"** to exit the program.

---

## 💡 Features

- Room options:
  - Standard (PHP 240.00/night, max 2 guests)
  - Suite (PHP 400.00/night, max 4 guests)
  - Deluxe (PHP 600.00/night, max 4 guests)
  - Luxury (PHP 800.00/night, max 6 guests)
- Input validation for room choice and nights
- Multiple reservation support in one session

---

## 📌 Notes

- This is a console application. GUI support is not included.
- No database is used—reservations are stored temporarily in memory.

---
