const xValues = [50,60,70,80,90,100,110,120,130,140,150];
const yValues = [7,8,8,9,9,9,10,11,14,14,15];

new Chart("chart_sale_today", {
  type: "line",
  data: {
    labels: xValues,
    datasets: [{
      fill: false,
      lineTension: 0,
      backgroundColor: "rgba(0,0,255,1.0)",
      borderColor: "rgba(0,0,255,0.1)",
      data: yValues
    }]
  },
  options: {
    legend: {display: false},
    scales: {
      yAxes: [{ticks: {min: 6, max:16}}],
    }
  }
});

const xValuesa = [50,60,70,80,90,100,110,120,130,140,150];
const yValuesb = [7,8,8,9,9,9,10,11,14,14,15];

new Chart("chart_customer", {
  type: "line",
  data: {
    labels: xValuesa,
    datasets: [{
      fill: false,
      lineTension: 0,
      backgroundColor: "rgba(0,0,255,1.0)",
      borderColor: "rgba(0,0,255,0.1)",
      data: yValuesb
    }]
  },
  options: {
    legend: {display: false},
    scales: {
      yAxes: [{ticks: {min: 6, max:16}}],
    }
  }
});


var xValuesc = ["Italy", "France", "Spain", "USA", "Argentina"];
var yValuesd = [55, 49, 44, 24, 15];
var barColors = ["red", "green","blue","orange","brown"];

new Chart("top_ten", {
  type: "bar",
  data: {
    labels: xValuesc,
    datasets: [{
      backgroundColor: barColors,
      data: yValuesd
    }]
  },
  options: {
    legend: {display: false},
    title: {
      display: true,
      text: "World Wine Production 2018"
    }
  }
});