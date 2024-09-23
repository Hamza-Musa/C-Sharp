<?php
class StringUtilities {
  public static function
  secondCase ($static) {
    $string = strtolower($string);
    $string[1] = strtolower($string[1]);
    return $string;
    php echo StringUtils::secondCase("MCDONALD"); echo StringUtils::secondCase("baldwin"); echo StringUtils::secondCase("Q");
    if (strlen($string) >= 2) {
      $string[1] = strtoupper($string[1]);
    }
  }
}




class Pajamas {
  private $owner, $fit, $color;
  public function describe() {
    return "$this->owner's $this->color pajamas fit $this->fit.";
  }
  function __construct(
    $owner = "unclaimed",
    $fit = "fine",
    $color = "white"
  ) {
    $this->owner = StringUtils::secondCase($owner);
    $this->fit = $fit;
    $this->color = $color;
  }
  $chicken_PJs = new Pajamas("CHICKEN", "just right", "purple");
echo $chicken_PJs->describe();
public function setFit($new_fit) {
  $this->fit = $new_fit;
  echo "\n...they wash their PJs many times....";
$chicken_PJs->setFit("a little tight");
echo "\n";
echo $chicken_PJs->describe();
}
}

class ButtonablePajamas extends Pajamas
{
 private $button_state = "unbuttoned";
 public function describe() {
  return parent::describe() . " They also have buttons which are currently $this->button_state.";
  $moose_PJs = new ButtonablePajamas("moose", "kind of loose", "red");
echo "\n";
echo $moose_PJs->describe();
public function toggleButtons() {
  if ($this->button_state === "unbuttoned") {
    $this->button_state = "buttoned";
  } else {
    $this->button_state = "unbuttoned";
  }
}
}

}

