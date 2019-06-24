import React, { useEffect, useState } from 'react';
import axios from 'axios';

export default function SubApp() {
  const [data, setData] = useState([]);

  useEffect(() => {
    axios
      .get("http://localhost:5002/api/ethics")
      .then(result => setData(result.data));
  }, []);

  return (
    <div>
      <p>Hello Ethics!</p>
      <ul>
        {data.map(item => (
          <li key={item}>
            {item}
          </li>
        ))}
      </ul>
      <hr />
    </div>
  );
}