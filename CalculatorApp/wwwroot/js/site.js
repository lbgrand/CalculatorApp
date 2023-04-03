function computeValue() {
  let operand1 = document.getElementById("operand1").value;
  let operand2 = document.getElementById("operand2").value;
  let operator = document.getElementById("operator").value;
  let resultField = document.getElementById("result");

  if (!operand1 || !operand2 || isNaN(operand1) || isNaN(operand2)) {
    resultField.value = "Please enter numbers";
    return;
  }

  if (operand2 == 0 && operator === "divide") {
    resultField.value = "Zero division disallowed";
    return;
  }

  fetch(`api/${operator}/${operand1}/${operand2}`)
  .then((response) => {
    if (!response.ok) {
      return "Error";
    } else {
      return response.json();
    }
  })
  .then((result) => resultField.value = result);
}