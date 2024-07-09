## Project: Pajamas and String Utilities

This project contains two PHP classes that handle different functionalities. The `StringUtilities` class provides a utility method for string manipulation, and the `Pajamas` class models a piece of clothing with attributes and methods to describe its state. An additional `ButtonablePajamas` class extends the `Pajamas` class to add button-related functionality.

### Table of Contents

1. [Requirements](#requirements)
2. [Installation](#installation)
3. [Usage](#usage)
4. [Classes](#classes)
    - [StringUtilities](#stringutilities)
    - [Pajamas](#pajamas)
    - [ButtonablePajamas](#buttonablepajamas)
5. [Issues](#issues)

### Requirements

- PHP 7.0 or higher

### Installation

1. Ensure PHP is installed on your system.
2. Clone this repository or download the source code.
3. Place the PHP file in your desired directory.
4. Run the PHP file using the PHP CLI: `php filename.php`.

### Usage

This script demonstrates the usage of the classes provided. To run the example code, execute the script in your terminal or web server environment.

### Classes

#### StringUtilities

The `StringUtilities` class contains a static method for string manipulation:

- **Methods:**
  - `public static function secondCase($string)`: This method takes a string input and returns the string with its second character in uppercase. If the string has less than 2 characters, it returns the string as is.

#### Pajamas

The `Pajamas` class models a piece of clothing with attributes for owner, fit, and color:

- **Attributes:**
  - `private $owner`: The owner of the pajamas.
  - `private $fit`: The fit of the pajamas.
  - `private $color`: The color of the pajamas.
- **Methods:**
  - `public function describe()`: Returns a string describing the pajamas.
  - `public function setFit($new_fit)`: Sets a new fit for the pajamas.
  - `public function __construct($owner = "unclaimed", $fit = "fine", $color = "white")`: Constructor to initialize the pajamas object.

#### ButtonablePajamas

The `ButtonablePajamas` class extends the `Pajamas` class and adds button functionality:

- **Attributes:**
  - `private $button_state = "unbuttoned"`: The state of the buttons.
- **Methods:**
  - `public function describe()`: Returns a string describing the pajamas, including the button state.
  - `public function toggleButtons()`: Toggles the button state between "buttoned" and "unbuttoned".

### Issues

This script has several issues that need addressing:
1. **Syntax Errors and Code Placement:**
   - The `StringUtilities` class has a misplaced echo and `if` block.
   - The `Pajamas` and `ButtonablePajamas` classes have misplaced object instantiations and method calls inside the class definitions.

2. **Functionality Errors:**
   - The `StringUtilities::secondCase` method has incorrect logic for handling the second character of the string.

3. **Object Instantiation:**
   - Objects should be instantiated outside the class definitions.

### Example Code

```php
<?php
class StringUtilities {
  public static function secondCase($string) {
    $string = strtolower($string);
    if (strlen($string) >= 2) {
      $string[1] = strtoupper($string[1]);
    }
    return $string;
  }
}

class Pajamas {
  private $owner, $fit, $color;

  function __construct($owner = "unclaimed", $fit = "fine", $color = "white") {
    $this->owner = StringUtilities::secondCase($owner);
    $this->fit = $fit;
    $this->color = $color;
  }

  public function describe() {
    return "$this->owner's $this->color pajamas fit $this->fit.";
  }

  public function setFit($new_fit) {
    $this->fit = $new_fit;
    echo "\n...they wash their PJs many times....";
  }
}

class ButtonablePajamas extends Pajamas {
  private $button_state = "unbuttoned";

  public function describe() {
    return parent::describe() . " They also have buttons which are currently $this->button_state.";
  }

  public function toggleButtons() {
    if ($this->button_state === "unbuttoned") {
      $this->button_state = "buttoned";
    } else {
      $this->button_state = "unbuttoned";
    }
  }
}

// Example usage
$chicken_PJs = new Pajamas("CHICKEN", "just right", "purple");
echo $chicken_PJs->describe();

$chicken_PJs->setFit("a little tight");
echo "\n";
echo $chicken_PJs->describe();

$moose_PJs = new ButtonablePajamas("moose", "kind of loose", "red");
echo "\n";
echo $moose_PJs->describe();
$moose_PJs->toggleButtons();
echo "\n";
echo $moose_PJs->describe();
?>
```

