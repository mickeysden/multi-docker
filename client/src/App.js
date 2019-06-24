import React, { useEffect, useState } from 'react';
import axios from 'axios';

export default function App() {
  const [data, setData] = useState([]);

  useEffect(() => {
    axios
      .get("http://localhost:5000/api/values")
      .then(result => setData(result.data));
  }, []);

  return (
    <div>
      <p>jello!</p>
      <ul>
        {data.map(item => (
          <li key={item.name}>
            {item.name}: {item.value}
          </li>
        ))}
      </ul>
    </div>
  );
}