// Dummy exchange rates relative to 1 USD
const rates = {
  USD: 1,
  INR: 83.3,
  EUR: 0.92,
  JPY: 156.7
};

function convertCurrency() {
  const amount = parseFloat(document.getElementById("amount").value);
  const from = document.getElementById("fromCurrency").value;
  const to = document.getElementById("toCurrency").value;
  const resultDiv = document.getElementById("result");

  if (isNaN(amount) || amount <= 0) {
    resultDiv.innerHTML = `<p>⚠️ Please enter a valid amount to convert.</p>`;
    return;
  }

  if (from === to) {
    resultDiv.innerHTML = `<p>🔁 You're converting the same currency!</p>`;
    return;
  }

  // Convert amount to USD, then to target currency
  const inUSD = amount / rates[from];
  const convertedAmount = inUSD * rates[to];
  const rounded = convertedAmount.toFixed(2);

  resultDiv.innerHTML = `
    <p>✅ <strong>${amount} ${from}</strong> equals <strong>${rounded} ${to}</strong></p>
  `;
}
