/* Make the whole page a flex container that centers everything */
body, html {
  height: 100%;
  margin: 0;
  font-family: 'Segoe UI', sans-serif;
  background: linear-gradient(to right, #c2e9fb, #a1c4fd);

  display: flex;
  justify-content: center; /* horizontal center */
  align-items: center;     /* vertical center */
  text-align: center;      /* center text inside container */
}

/* The white box container */
.converter-container {
  background: white;
  padding: 30px 40px;
  border-radius: 20px;
  width: 380px;
  box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);

  display: flex;
  flex-direction: column;
  align-items: center; /* center all children horizontally */
}

/* Uniform spacing and full width inputs/selects */
input[type="number"],
select {
  padding: 12px;
  width: 100%;
  border-radius: 10px;
  border: 1px solid #ccc;
  font-size: 16px;
  box-sizing: border-box;
  margin-bottom: 15px;
}

/* Flex row for currency selectors, centered */
.select-row {
  display: flex;
  justify-content: center;
  gap: 15px;
  width: 100%;
  margin-bottom: 15px;
}

/* Button styling */
button {
  padding: 10px 20px;
  background-color:rgb(10, 145, 66);
  color: white;
  border: none;
  font-size: 16px;
  border-radius: 10px;
  cursor: pointer;
  transition: background-color 0.3s ease;
  width: 100%;
}

button:hover {
  background-color:rgb(77, 172, 117);
}

/* Result text */
.result-box {
  font-size: 18px;
  color: #34495e;
  margin-top: 20px;
}
