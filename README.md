# 🛒 E-Commerce Test Automation Framework

**Tech Stack**: C# | Selenium WebDriver | NUnit | ChromeDriver | Page Object Model

A robust automation framework for testing e-commerce workflows (product browsing, cart management, checkout). Designed for CI/CD integration.

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
![GitHub last commit](https://img.shields.io/github/last-commit/jai2970/ECommerceAutomation)

---

## 🚀 Features
- **End-to-End UI Testing**: Automated critical user journeys (login → product selection → checkout)
- **Modular Architecture**: 
  - `Pages/`: Page object classes
  - `Tests/`: NUnit test cases
  - `Utils/`: Helper methods
- **Cross-Browser**: ChromeDriver support (extensible to Firefox/Edge)
- **CI/CD Ready**: Pipeline-compatible structure (Jenkins/GitHub Actions)

---

## ⚙️ Setup

### Prerequisites
- .NET 6.0+
- Chrome browser (vLatest)
- [ChromeDriver](https://chromedriver.chromium.org/) (match your Chrome version)

### Installation
1. Clone the repo:
   ```bash
   git clone https://github.com/jai2970/ECommerceAutomation.git
